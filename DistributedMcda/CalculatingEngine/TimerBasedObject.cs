using System.Timers;

namespace CalculatingEngine
{
    public abstract class TimerBasedObject
    {
        protected Timer _timer;
        protected TimerBasedObject(int interval = 1000)
        {
            _timer = new Timer();
            _timer.Elapsed += OnTick;
            _timer.Interval = interval;
            _timer.Enabled = true;
            _timer.Start();
        }

        protected abstract void OnTick(object sender, ElapsedEventArgs e);

    }
}