using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingEngine.Data
{
    public class CalculationResult
    {
        public double[][] Data { get; set; }
        public TaskStatus Status { get; set; }
    }
}
