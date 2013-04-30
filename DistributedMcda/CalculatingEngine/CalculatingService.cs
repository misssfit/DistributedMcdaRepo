using System.Collections.Generic;
using System.ServiceModel;
using CalculatingEngine.Data;

namespace CalculatingEngine
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class CalculatingService :  ICalculatingService
    {
        private readonly TaskQueueManager _taskQueueManager = new TaskQueueManager();
        
        public List<MethodDescription> GetAllMethods()
        {
            return MethodRegistry.GetAll();
        }

        public List<KeyValuePair<TaskPool, List<TaskInfo>>> GetAllTasks()
        {
            var result = _taskQueueManager.GetAllTasks();
            return result;
           
        }

        public OperationStatus Calculate(string methodName, List<KeyValuePair<string, double[][]>> inputParameters)
        {
            var operationStatus = new OperationStatus();
            operationStatus.Id = _taskQueueManager.CreateNewTask(methodName, inputParameters);
            operationStatus.Status = RequestStatus.NotReady;
            return operationStatus;
        }

        public OperationStatus DeleteTask(string id)
        {
            var operationStatus = new OperationStatus();
            operationStatus.Id = id;
            operationStatus.Status = _taskQueueManager.DeleteTask(id) ? RequestStatus.Ok : RequestStatus.Error;
            return operationStatus;
        }

        public CalculationResult GetResult(string id)
        {
            var calculationResult = _taskQueueManager.GetResult(id);
            return calculationResult;
        }

        public OperationStatus PrioritizeTask(string id)
        {
            var operationStatus = new OperationStatus();
            operationStatus.Id = id;
            operationStatus.Status = _taskQueueManager.PrioritizeTask(id) ? RequestStatus.Ok : RequestStatus.Error;
            return operationStatus;
        }
    }
}
