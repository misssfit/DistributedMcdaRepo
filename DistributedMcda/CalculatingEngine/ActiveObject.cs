using System.Threading;

namespace CalculatingEngine
{
    public abstract class ActiveObject
    {
        public bool IsActive { get; protected set; }
        protected Thread _thread;

        public void Run()
        {
            IsActive = true;
            _thread = new Thread(new ThreadStart(PerformAction));
            _thread.Start();

        }

        public void Stop()
        {
            IsActive = false;
            _thread.Abort();
        }

        protected abstract void PerformAction();
    }
}
