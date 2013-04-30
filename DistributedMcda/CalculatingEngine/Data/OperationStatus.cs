using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingEngine.Data
{
    public class OperationStatus
    {
        public string Id { get; set; }
        public RequestStatus Status { get; set; }
    }
}
