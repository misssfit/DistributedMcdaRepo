using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CalculatingEngine.Data;
using McdaLibrary;

namespace CalculatingEngine
{
    public static class MethodRegistry
    {

        private static List<McdaMethodInfo> _methods;

        static MethodRegistry()
        {
            _methods = new List<McdaMethodInfo>();
            RegisterAllKnownMethods();
        }

        private static void RegisterAllKnownMethods()
        {
            var methodMetadata = new McdaMethodInfo
            {
                Name = "Promethee",
                ObjectType = typeof(Promethee),
                Input = new List<string> { "weights", "evaluationTable" },
            };
            _methods.Add(methodMetadata);
        }

        public static void RegisterMethod(McdaMethodInfo methodInfo)
        {
            lock (_methods)
            {
                if (_methods.Any(p => p.Name == methodInfo.Name) == false)
                {
                    _methods.Add(methodInfo);
                }
                else
                {
                    throw new Exception("Method with given name is already registred.");
                }
            }
        }

        internal static List<MethodDescription> GetAll()
        {
            lock (_methods)
            {
                return _methods.Select(p => new MethodDescription { MethodName = p.Name, Parameters = p.Input }).ToList();
            }
        }

        internal static IMcdaMethod GetMethodObject(string methodName)
        {
            if (_methods.Any(p => p.Name == methodName) == true)
            {
                var info = _methods.Single(p => p.Name == methodName);
                return (IMcdaMethod)Activator.CreateInstance(info.ObjectType);

            }
            else
            {
                throw new Exception("Unknown method");
            }
        }
    }
}
