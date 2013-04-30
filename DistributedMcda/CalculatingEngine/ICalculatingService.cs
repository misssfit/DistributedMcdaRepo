using System.Collections.Generic;
using System.ServiceModel;
using CalculatingEngine.Data;


namespace CalculatingEngine
{
    [ServiceContract]
    public interface ICalculatingService
    {
        [OperationContract]
        List<MethodDescription> GetAllMethods();

        [OperationContract]
        List<KeyValuePair<TaskPool,List<TaskInfo>>> GetAllTasks();

        [OperationContract]
        OperationStatus Calculate(string methodName, List<KeyValuePair<string, double[][]>> inputParameters);

        [OperationContract]
        OperationStatus DeleteTask(string id);

        [OperationContract]
        CalculationResult GetResult(string id);

        [OperationContract]
        OperationStatus PrioritizeTask(string id);
    }
}
