using System.Collections.Generic;
using System.ServiceModel;
using CalculatingEngine.Data;


namespace CalculatingEngine
{
    [ServiceContract]
    public interface ICalculatingService : ITaskDeleter
    {
        [OperationContract]
        List<MethodDescription> GetAllMethods();

        [OperationContract]
        OperationStatus Calculate(string methodName, List<KeyValuePair<string, double[][]>> inputParameters);

        [OperationContract]
        CalculationResult GetResult(string id);

    }
}
