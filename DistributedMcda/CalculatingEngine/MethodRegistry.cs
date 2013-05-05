using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition.Primitives;
using System.IO;
using System.Linq;
using System.Reflection;
using CalculatingEngine.Data;
using McdaLibrary;

namespace CalculatingEngine
{
    public class MethodRegistry
    {
        private static MethodRegistry _instance;
        private static object _instanceLock = new object();
        private static object _methodListLock = new object();


        public static MethodRegistry Instance
        {
            get
            {
                lock (_instanceLock)
                {
                    if (_instance == null)
                    {
                        _instance = new MethodRegistry();
                    }
                    return _instance;
                }
            }
        }

        [ImportMany(typeof(IMcdaMethod))]
        private List<IMcdaMethod> _methods;

        private FileSystemWatcher _fileSystemWatcher;
        public string _externalLibraryPath = "..\\..\\..\\ExternalLibraries";
        private readonly DirectoryInfo _directoryInfo;

        protected MethodRegistry()
        {
            AppDomain.CurrentDomain.SetShadowCopyFiles();
            _directoryInfo = new DirectoryInfo(_externalLibraryPath);

            Compose();
        }

        public void Run()
        {
            if (_fileSystemWatcher == null)
            {
                try
                {
                    _fileSystemWatcher = new FileSystemWatcher();
                    _fileSystemWatcher.Path = _directoryInfo.FullName;
                    /* Watch for changes in LastAccess and LastWrite times, and
                   the renaming of files or directories. */
                    _fileSystemWatcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.FileName;
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

        public void RefreshMethodRegistry()
        {
            Compose();
        }
        private void OnChanged(object source, FileSystemEventArgs e)
        {
            // Specify what is done when a file is changed, created, or deleted.
            Console.WriteLine("(@) File: " + e.FullPath + " " + e.ChangeType);
            Compose();
        }

        internal List<MethodDescription> GetAll()
        {
            lock (_methodListLock)
            {
                return _methods.Select(p => new MethodDescription { MethodName = p.MethodMetadata.Name, Parameters = p.MethodMetadata.Input }).ToList();
            }
        }


        internal IMcdaMethod GetMethodObject(string methodName)
        {
            lock (_methodListLock)
            {

                if (_methods.Any(p => p.MethodMetadata.Name == methodName) == true)
                {
                    var method = _methods.Single(p => p.MethodMetadata.Name == methodName);
                    return method;

                }
                else
                {
                    throw new Exception("Unknown method");
                }
            }
        }

        private void Compose()
        {
            try
            {
                lock (_methodListLock)
                {

                    var directoryCatalog = new DirectoryCatalog(_directoryInfo.FullName);
                    var assemblyCatalog = new AssemblyCatalog(Assembly.GetExecutingAssembly());
                    var catalog = new AggregateCatalog(new ComposablePartCatalog[] { assemblyCatalog, directoryCatalog });

                    var container = new CompositionContainer(catalog);
                    container.ComposeParts(this);
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("! " + e.Message);
            }

        }

    }
}
