using System;

namespace BasicStopwatch
{
    class Stopwatch
    {
        private DateTime _startTime;
        private int _endTime;
        private bool _hasStarted = false;

        //Method will set start time to current time, or print error message if watch is already started
        public void StartWatch()
        {
            if (_hasStarted)
            {
                Console.WriteLine("Watch has already started. Must enter stop first");
            }
            else
            {
                _startTime = DateTime.Now;
                _hasStarted = true;
            }
           
        }

        //Method will calculate end time, or print error message if clock is already stopped
        public void EndWatch()
        {
            if (!_hasStarted)
            {
                Console.WriteLine("Watch is already stopped. Must enter start first");
            }
            else
            {
                var timeSpan = DateTime.Now - _startTime;
                _endTime = timeSpan.Seconds;
                _hasStarted = false;
            }
            
        }

        //Method will format time duration into readable string
        public string DisplayTime()
        {
            TimeSpan t = TimeSpan.FromSeconds(_endTime); //Use timespan class to help format string
            string time = string.Format("{0:D2}h:{1:D2}m:{2:D2}s",
                            t.Hours,
                            t.Minutes,
                            t.Seconds);
            return time;
        }

    }
}
