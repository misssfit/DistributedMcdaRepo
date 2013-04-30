using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingEngine.Data
{
    public class TaskInfo
    {
        public string MethodName { get; set; }
        public string Id { get; set; }
        public TaskStatus Status { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime CalculationStartTime { get; set; }

    }
}
