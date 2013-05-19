using System.Collections.Generic;
using System.ServiceModel;
using CalculatingEngine.Data;

namespace CalculatingEngine
{
    [ServiceContract]
    public interface IAdministrationService : ITaskDeleter
    {
        [OperationContract]
        List<KeyValuePair<TaskPool, List<TaskInfo>>> GetAllTasks();

        [OperationContract]
        OperationStatus PrioritizeTask(string id);

        [OperationContract]
        OperationStatus DeleteAll(TaskPool pool);

        [OperationContract]
        void RefreshMethodRegistry();

        [OperationContract]
        void ConfigureTasksCalculationTimeout(int timeoutValue);

        [OperationContract]
        void ConfigureCalculatedTasksTimeout(int timeoutValue);
    }
}
