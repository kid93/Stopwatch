using System;
using System.Collections.Generic;

namespace Stopwatch
{
    public class Stopwatch
    {

        private DateTime _start;
        private DateTime _stop;
        private bool _hasStarted;
        private readonly List<TimeSpan> _totalDuration;

        public TimeSpan Duration
        {
            get
            {
                var sum = TimeSpan.Zero;
                foreach (TimeSpan timeSpan in _totalDuration)
                {
                    sum += timeSpan;
                }
                return sum;
            }
        }

        public Stopwatch()
        {
            _hasStarted = false;
            _totalDuration = new List<TimeSpan>();
        }


        public void Start()
        {
            if (!_hasStarted)
            {
                _start = DateTime.Now;
                _hasStarted = true;
            }
            else
            {
                throw new InvalidOperationException(nameof(_start));
            }
        }

        public void Stop()
        {
            if (_hasStarted)
            {
                _stop = DateTime.Now;
                _hasStarted = false;

                AddDurationToList();
            }
        }

        private void AddDurationToList()
        {
            _totalDuration.Add(_stop - _start);
        }

    }
}