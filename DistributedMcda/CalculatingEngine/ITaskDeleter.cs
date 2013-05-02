using System.ServiceModel;
using CalculatingEngine.Data;

namespace CalculatingEngine
{
    [ServiceContract]
    public interface ITaskDeleter
    {
        [OperationContract]
        OperationStatus DeleteTask(string id);
    }
}
