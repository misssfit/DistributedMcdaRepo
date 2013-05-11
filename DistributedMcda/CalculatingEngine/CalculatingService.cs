using System.Collections.Generic;
using System.ServiceModel;
using CalculatingEngine.Data;

namespace CalculatingEngine
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class CalculatingService : ICalculatingService, IAdministrationService
    {
        public CalculatingService()
        {
            MethodRegistry.Instance.Run();
        }
        public List<MethodDescription> GetAllMethods()
        {
            return MethodRegistry.Instance.GetAll();
        }

        public List<KeyValuePair<TaskPool, List<TaskInfo>>> GetAllTasks()
        {
            var result = TaskQueueManager.Instance.GetAllTasks();
            return result;
        }

        public OperationStatus Calculate(string methodName, List<KeyValuePair<string, double[][]>> inputParameters)
        {
            var operationStatus = new OperationStatus();
            operationStatus.Id = TaskQueueManager.Instance.CreateNewTask(methodName, inputParameters);
            operationStatus.Status = RequestStatus.NotReady;
            return operationStatus;
        }

        public OperationStatus DeleteTask(string id)
        {
            var operationStatus = new OperationStatus();
            operationStatus.Id = id;
            operationStatus.Status = TaskQueueManager.Instance.DeleteTask(id) ? RequestStatus.Ok : RequestStatus.Error;
            return operationStatus;
        }

        public CalculationResult GetResult(string id)
        {
            var calculationResult = TaskQueueManager.Instance.GetResult(id);
            return calculationResult;
        }

        public OperationStatus PrioritizeTask(string id)
        {
            var operationStatus = new OperationStatus();
            operationStatus.Id = id;
            operationStatus.Status = TaskQueueManager.Instance.PrioritizeTask(id) ? RequestStatus.Ok : RequestStatus.Error;
            return operationStatus;
        }

        public OperationStatus DeleteAll(TaskPool pool)
        {
            var operationStatus = new OperationStatus();
            operationStatus.Status = TaskQueueManager.Instance.DeleteAll(pool) ? RequestStatus.Ok : RequestStatus.Error;
            return operationStatus;
        }

        public void RefreshMethodRegistry()
        {
            MethodRegistry.Instance.RefreshMethodRegistry();
        }
    }
}
