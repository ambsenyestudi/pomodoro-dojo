using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PomodoroKata.Library
{
    public class Pomodoro
    {
        public CountDownStatus Status { get; private set; }
        //lacks in Minutes
        public int Duration { get; set; }
        public bool CanEnd
        {
            get { return Status == CountDownStatus.started; }
        }

        public int NInterruptions { get; private set; }

        public Pomodoro()
        {
            initializeProperties();
        }
        private void initializeProperties()
        {
            Duration = 25;
            Status = CountDownStatus.stopped;
        }
        public void Start()
        {
            Status = CountDownStatus.started;
            runCountDownAsync();
        }
        private async void runCountDownAsync()
        {
            await Task.Delay(TimeSpan.FromMinutes(Duration));
            Status = CountDownStatus.ended;
        }
    }
    public enum CountDownStatus
    {
        stopped,
        started,
        interrupted,
        ended
    }
}
