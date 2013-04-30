using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McdaLibrary
{
    public interface IMcdaMethod
    {
       // McdaMethodInfo MethodMetadata { get; }
        double[][] Calculate(List<KeyValuePair<string, double[][]>> _inputParameters);
    }
}
