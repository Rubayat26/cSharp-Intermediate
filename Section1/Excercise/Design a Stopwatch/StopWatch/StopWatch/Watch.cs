// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace StopWatch
{
    public class Watch
    {
        private DateTime _startTime;
        private DateTime _stopTime;
        private bool _isRunning;

        public void Start()
        {
            if (_isRunning)
            {
                throw new InvalidOperationException("The watch is already running.");
            }
            _startTime = DateTime.Now;
            _isRunning = true;
            
           

        }

        public void Stop()
        {
            _stopTime = DateTime.Now;
            _isRunning = false;

            var timeSpan = _stopTime - _startTime;

            Console.WriteLine(timeSpan.ToString("ss") + " seconds");
        }
        
       
        
    }
       
}
    