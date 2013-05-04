using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Permissions;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using CalculatingEngine.Data;
using McdaLibrary;

namespace CalculatingEngine
{
    public static class MethodRegistry
    {

        private static List<Tuple<McdaMethodInfo, string>> _methods;
        private static FileSystemWatcher _fileSystemWatcher;
        public static string _externalLibraryPath = "..\\..\\..\\ExternalLibraries";
        private static readonly DirectoryInfo _directoryInfo = new DirectoryInfo(_externalLibraryPath);

        private static readonly Type _interfaceType = typeof(IMcdaMethod);

        static MethodRegistry()
        {
            _methods = new List<Tuple<McdaMethodInfo, string>>();
            RefreshMethodRegistry();
        }
        public static void Run()
        {
            if (_fileSystemWatcher == null)
            {
                try
                {
                    _fileSystemWatcher = new FileSystemWatcher();
                    _fileSystemWatcher.Path = _directoryInfo.FullName;
                    /* Watch for changes in LastAccess and LastWrite times, and
                   the renaming of files or directories. */
                    _fileSystemWatcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite |
                                                      NotifyFilters.FileName;
                    // Only watch text files.
                    _fileSystemWatcher.Filter = "*.dll";

                    // Add event handlers.
                    _fileSystemWatcher.Changed += OnChanged;
                    _fileSystemWatcher.Created += OnChanged;
                    _fileSystemWatcher.Deleted += OnChanged;

                    // Begin watching.
                    _fileSystemWatcher.EnableRaisingEvents = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("! Exception occured starting file watcher." + e.Message);
                }

            }

        }
        private static void OnChanged(object source, FileSystemEventArgs e)
        {
            // Specify what is done when a file is changed, created, or deleted.
            Console.WriteLine("(@) File: " + e.FullPath + " " + e.ChangeType);

            switch (e.ChangeType)
            {
                case WatcherChangeTypes.Created:
                    RegisterExternalLibraries(e.FullPath);
                    break;
                case WatcherChangeTypes.Deleted:
                    DeregisterExternalLibraries(e.FullPath);
                    break;
                case WatcherChangeTypes.Changed:
                    DeregisterExternalLibraries(e.FullPath);
                    RegisterExternalLibraries(e.FullPath);
                    break;
            }

        }

        private static void DeregisterExternalLibraries(string path)
        {
            lock (_methods)
            {
                _methods.RemoveAll(p => p.Item2 == path);
            }
        }

        private static void RegisterAllKnownMethods()
        {
            var types =
                _interfaceType.Assembly.GetTypes()
                             .Where(p => p != _interfaceType && _interfaceType.IsAssignableFrom(p))
                             .ToList();
            AddTypesToRegistry(types);

        }

        private static void AddTypesToRegistry(List<Type> types, string assemblyPath = "")
        {
            lock (_methods)
            {
                foreach (var type in types)
                {
                    var methodObject = (IMcdaMethod)Activator.CreateInstance(type);
                    var methodMetadata = methodObject.MethodMetadata;
                    if (_methods.Any(p => p.Item1.Name == methodMetadata.Name) == false)
                    {
                        _methods.Add(Tuple.Create(methodMetadata, assemblyPath));
                    }
                }
            }
        }

        internal static List<MethodDescription> GetAll()
        {
            lock (_methods)
            {
                return _methods.Select(p => new MethodDescription { MethodName = p.Item1.Name, Parameters = p.Item1.Input }).ToList();
            }
        }

        internal static void RefreshMethodRegistry()
        {
            RegisterAllKnownMethods();
            foreach (var dll in _directoryInfo.EnumerateFiles().Where(p => p.Extension == ".dll").ToList())
            {
                RegisterExternalLibraries(dll.FullName);
            }

        }

        private static void RegisterExternalLibraries(string assemblyPath)
        {
            try
            {
                var assembly = Assembly.LoadFrom(assemblyPath);

                var types =
                    assembly.GetTypes().Where(p => p != _interfaceType && _interfaceType.IsAssignableFrom(p)).ToList();
                AddTypesToRegistry(types, assemblyPath);
                
            }
            catch (Exception e)
            {
                Console.WriteLine("! Exception occured during loading external library: " + assemblyPath + ". " + e.Message);
            }

        }

        internal static IMcdaMethod GetMethodObject(string methodName)
        {
            if (_methods.Any(p => p.Item1.Name == methodName) == true)
            {
                var info = _methods.Single(p => p.Item1.Name == methodName);
                return (IMcdaMethod)Activator.CreateInstance(info.Item1.ObjectType);

            }
            else
            {
                throw new Exception("Unknown method");
            }
        }
    }
}
