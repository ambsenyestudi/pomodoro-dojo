using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PomodoroKata.Library;
using System.Threading.Tasks;

namespace PomodoroKata.UnitTest
{
    [TestClass]
    public class Pomodoro_Stop_UnitTest
    {
        private Pomodoro _pomodoro;
        [TestInitialize]
        public void InitializePomodoro()
        {
            _pomodoro = new Pomodoro();
        }

        [TestMethod]
        public void Pomodoro_StopDefault_Test()
        {
            Assert.AreEqual(true, true);
        }
        [TestMethod]
        public void PomodoredShouldBeStoppedWhenCreated()
        {
            CountDownStatus exptedStopped = CountDownStatus.stopped;
            Assert.AreEqual(_pomodoro.Status, exptedStopped);
        }
        [TestMethod]
        public void WhenStartedPomodoroShouldBeginCountDown()
        {
            _pomodoro.Start();
            CountDownStatus expectedIsCountDownActive = CountDownStatus.started;
            Assert.AreEqual(_pomodoro.Status, expectedIsCountDownActive);
        }
        [TestMethod]
        public void PomodoroShouldNotEndIfItHasNotStarted()
        {
            bool expectedCanEnd = false;

            //checkit really?
            /*Stop?
             *
            */
            Assert.AreEqual(_pomodoro.CanEnd, expectedCanEnd);
        }
        [TestMethod]
        public void PomodoroEndsWhenTimesRunsOut()
        {
            _pomodoro.Duration = 0;
            _pomodoro.Start();
            CountDownStatus expctedStatus = CountDownStatus.ended;
            Assert.AreEqual(_pomodoro.Status, expctedStatus);
        }
        [TestMethod]
        public void PomodoroShouldNotEndUntilTiemeRunsOut()
        {
            _pomodoro.Duration = 1;
            _pomodoro.Start();

            CountDownStatus expctedStatus = CountDownStatus.started;
            Assert.AreEqual(_pomodoro.Status, expctedStatus);
        }
        /*
         * A newly created pomodoro stands.
When starting a pomodoro begins the countdown.
A pomodoro does not end if it has not been started previously.
A pomodoro ends when its runs out.
A pomodoro not end until it runs out time.
        */
    }
}
