using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PomodoroKata.Library;

namespace PomodoroKata.UnitTest
{
    [TestClass]
    public class PomodoroResetUnitTest
    {
        private Pomodoro _pomodoro;
        [TestInitialize]
        public void InitializePomodoro()
        {
            _pomodoro = new Pomodoro();
        }

        [TestMethod]
        public void Pomodoro_ResetDefault_Test()
        {
            Assert.AreEqual(true, true);
        }
        /*
        REINICIAR
        Un pomodoro ya arrancado se reinicia(empieza a contar el tiempo) al arrancarlo de nuevo.
        Un pomodoro se reinicia sin interrupciones.
        */
    }
}
