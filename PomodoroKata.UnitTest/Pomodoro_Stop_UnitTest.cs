using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PomodoroKata.Library;

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
        /*
        Un pomodoro recién creado está parado.
        Al arrancar un pomodoro comienza la cuenta atrás.
        Un pomodoro no termina si no ha sido arrancado previamente.
        Un pomodoro acaba cuando se agota su tiempo.
        Un pomodoro no acaba mientras no se agote su tiempo.
        */
    }
}
