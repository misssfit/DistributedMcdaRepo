using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;
using CalculatingEngine.Data;

namespace CalculatingEngine
{
    public class TaskQueueManager : TimerBasedObject
    {
        private static TaskQueueManager _instance;
        private static object _instanceLock = new object();
        public static TaskQueueManager Instance
        {
            get
            {
                lock (_instanceLock)
                {
                    if (_instance == null)
                    {
                        _instance = new TaskQueueManager();
                    }
                    return _instance;
                }
            }
        }

        private List<CalculationTask> _tasksQueue = new List<CalculationTask>();
        private List<CalculationTask> _activeTasks = new List<CalculationTask>();
        private List<CalculationTask> _inactiveTasks = new List<CalculationTask>();

        protected Timer _cleanInactiveTasksTimer;
        protected Timer _cleanTimedOutTasksTimer;

        protected TaskQueueManager()
            : base(Configuration.TasksQueueManagerCheckInterval)
        {
            _cleanInactiveTasksTimer = new Timer();
            _cleanInactiveTasksTimer.Elapsed += CleanInactiveTasks;
            _cleanInactiveTasksTimer.Interval = Configuration.CalculatedTasksTimeoutCheckInterval;
            _cleanInactiveTasksTimer.Enabled = true;
            _cleanInactiveTasksTimer.Start();

            _cleanTimedOutTasksTimer = new Timer();
            _cleanTimedOutTasksTimer.Elapsed += CleanTimedOutTasks;
            _cleanTimedOutTasksTimer.Interval = Configuration.TasksCalculationTimeoutCheckInterval;
            _cleanTimedOutTasksTimer.Enabled = true;
            _cleanTimedOutTasksTimer.Start();
        }


        internal string CreateNewTask(string methodName, List<KeyValuePair<string, double[][]>> inputParameters)
        {
            lock (_tasksQueue)
            {
                var task = new CalculationTask(methodName, inputParameters);
                _tasksQueue.Add(task);
                Console.WriteLine("Created task: " + task.ToString());
                return task.Id;
            }
        }

        internal bool DeleteTask(string id)
        {
            CalculationTask task = null;
            lock (_tasksQueue)
            {
                if (_tasksQueue.Any(p => p.Id == id) == true)
                {
                    task = _tasksQueue.Single(p => p.Id == id);
                    _tasksQueue.Remove(task);
                    Console.WriteLine("Deleted task from queue with id: " + id);
                    return true;
                }
            }
            lock (_inactiveTasks)
            {
                if (_inactiveTasks.Any(p => p.Id == id) == true)
                {
                    task = _inactiveTasks.Single(p => p.Id == id);
                    _inactiveTasks.Remove(task);
                    Console.WriteLine("Deleted task from inactive task list with id: " + id);
                    return true;
                }
            }
            lock (_activeTasks)
            {
                if (_activeTasks.Any(p => p.Id == id) == true)
                {
                    task = _activeTasks.Single(p => p.Id == id);
                    _activeTasks.Remove(task);
                    try
                    {
                        task.Stop();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Cannot delete/stop task with id: " + id + ". " + ex.Message);
                        return false;
                    }
                    Console.WriteLine("Deleted task from inactive task list with id: " + id);
                    return true;
                }
            }

            Console.WriteLine("Cannot delete task with id: " + id + ". Task does not exist.");
            return false;
        }

        internal CalculationResult GetResult(string id)
        {
            var calculationResult = new CalculationResult();
            lock (_activeTasks)
            {
                if (_inactiveTasks.Any(p => p.Id == id) == true)
                {
                    CalculationTask task = null;
                    lock (_inactiveTasks)
                    {
                        task = _inactiveTasks.Single(p => p.Id == id);
                        calculationResult.Status = task.Status;
                        if (task.Status == TaskStatus.Calculated)
                        {
                            calculationResult.Data = task.Data;
                            _inactiveTasks.Remove(task);
                        }
                        else
                        {
                            _inactiveTasks.Remove(task);
                            Console.WriteLine("Cannot get result for task with id: " + id + ". Task is " + task.Status);
                        }
                    }
                    return calculationResult;
                }
            }
            lock (_activeTasks)
            {
                if (_activeTasks.Any(p => p.Id == id) == true)
                {
                    calculationResult.Status = TaskStatus.InProgress;
                    return calculationResult;
                }
            }
            lock (_tasksQueue)
            {
                if (_tasksQueue.Any(p => p.Id == id) == true)
                {
                    calculationResult.Status = TaskStatus.NotStarted;
                    return calculationResult;
                }
            }
            Console.WriteLine("Cannot get result for task with id: " + id + ". Task does not exist.");
            calculationResult.Status = TaskStatus.Corrupted;
            return calculationResult;
        }

        internal bool PrioritizeTask(string id)
        {
            lock (_tasksQueue)
            {
                if (_tasksQueue.Any(p => p.Id == id) == true)
                {
                    var task = _tasksQueue.Single(p => p.Id == id);
                    _tasksQueue.Remove(task);
                    _tasksQueue.Insert(0, task);
                    Console.WriteLine("Task with id: " + id + "moved to the top of the queue.");
                    return true;
                }
            }
            Console.WriteLine("Cannot move up task task with id: " + id + ". Task does not exist.");
            return false;
        }

        internal List<KeyValuePair<TaskPool, List<TaskInfo>>> GetAllTasks()
        {
            var result = new List<KeyValuePair<TaskPool, List<TaskInfo>>>();
            lock (_activeTasks)
            {
                var tasks = _activeTasks.Select(p => p.TaskInfo).ToList();
                result.Add(new KeyValuePair<TaskPool, List<TaskInfo>>(TaskPool.Active, tasks));
            }
            lock (_inactiveTasks)
            {
                var tasks = _inactiveTasks.Select(p => p.TaskInfo).ToList();
                result.Add(new KeyValuePair<TaskPool, List<TaskInfo>>(TaskPool.Inactive, tasks));
            }
            lock (_tasksQueue)
            {
                var tasks = _tasksQueue.Select(p => p.TaskInfo).ToList();
                result.Add(new KeyValuePair<TaskPool, List<TaskInfo>>(TaskPool.Queue, tasks));
            }

            return result;
        }

        internal bool DeleteAll(TaskPool pool)
        {
            Console.WriteLine("[bulk delete]" + pool);
            switch (pool)
            {
                case TaskPool.Queue:
                    lock (_tasksQueue)
                    {
                        _tasksQueue.Clear();
                    }
                    return true;

                case TaskPool.Inactive:
                    lock (_inactiveTasks)
                    {
                        _inactiveTasks.Clear();
                    }
                    return true;
                case TaskPool.Active:
                    lock (_activeTasks)
                    {
                        foreach (var task in _activeTasks)
                        {
                            try
                            {
                                task.Stop();
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("[bulk delete] Cannot delete/stop task with id: " + task.Id + ". " + ex.Message);
                            }
                        }
                    }
                    return true;
                default:
                    return false;
            }
        }



        protected override void OnTick(object sender, ElapsedEventArgs e)
        {
            lock (_activeTasks)
            {
                if (_activeTasks.Any(p => p.IsActive == false) == true)
                {
                    var tasksToMove = _activeTasks.Where(p => p.IsActive == false).ToList();
                    foreach (var task in tasksToMove)
                    {
                        Console.WriteLine("Finished: " + task);
                        _activeTasks.Remove(task);
                    }
                    lock (_inactiveTasks)
                    {
                        _inactiveTasks.AddRange(tasksToMove);
                    }
                }
                while (_activeTasks.Count < Configuration.ActiveTasksCount)
                {
                    lock (_tasksQueue)
                    {
                        if (_tasksQueue.Any() == true)
                        {
                            var task = _tasksQueue.First();
                            task.Run();
                            Console.WriteLine("Started: " + task);
                            _tasksQueue.RemoveAt(0);
                            _activeTasks.Add(task);
                        }
                    }
                }
            }
        }

        private void CleanTimedOutTasks(object sender, ElapsedEventArgs e)
        {
            lock (_activeTasks)
            {
                var toBeRemoved =
                    _activeTasks.FindAll(
                        p =>
                        DateTime.UtcNow.Subtract(p.CalculationStartTimestamp).TotalMilliseconds >=
                        Configuration.TasksCalculationTimeout);
                //if tasks are in progress, stop threads before deleting them
                toBeRemoved.Where(p => p.Status == TaskStatus.InProgress).ToList().ForEach(p => p.Stop());

                if (toBeRemoved.Count > 0)
                {
                    Console.WriteLine("Removing Timed Out Tasks in Progress | Count: " + toBeRemoved.Count);

                    foreach (var calculationTask in toBeRemoved)
                    {
                        Console.WriteLine("* To Remove:  " + calculationTask);
                        Console.WriteLine("** " +
                                          DateTime.UtcNow.Subtract(calculationTask.CreationTimestamp).TotalMilliseconds);
                    }
                    _activeTasks.RemoveAll(
                        p =>
                        DateTime.UtcNow.Subtract(p.CalculationStartTimestamp).TotalMilliseconds >=
                        Configuration.TasksCalculationTimeout);
                }
            }
        }

        private void CleanInactiveTasks(object sender, ElapsedEventArgs e)
        {
            lock (_inactiveTasks)
            {
                var toBeRemoved =
                    _inactiveTasks.FindAll(
                        p =>
                        DateTime.UtcNow.Subtract(p.CalculationFinishTimestamp).TotalMilliseconds >=
                        Configuration.CalculatedTasksTimeout);

                if (toBeRemoved.Count > 0)
                {
                    Console.WriteLine("Removing Timed Out inactive tasks | Count: " + toBeRemoved.Count);

                    foreach (var calculationTask in toBeRemoved)
                    {
                        Console.WriteLine("* To Remove:  " + calculationTask);
                        Console.WriteLine("** " +
                                          DateTime.UtcNow.Subtract(calculationTask.CreationTimestamp).TotalMilliseconds);
                    }
                    _inactiveTasks.RemoveAll(
                        p =>
                        DateTime.UtcNow.Subtract(p.CalculationFinishTimestamp).TotalMilliseconds >=
                        Configuration.CalculatedTasksTimeout);
                }
            }
        }

    }
}
