using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace McdaLibrary
{
    public class McdaMethodInfo
    {
        public string Name { get; set; }
        public List<string>  Input { get; set; }
       
        public Type ObjectType { get; set; }
    }
}
