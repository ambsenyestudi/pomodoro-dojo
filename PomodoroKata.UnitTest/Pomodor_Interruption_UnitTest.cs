using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PomodoroKata.Library;

namespace PomodoroKata.UnitTest
{
    [TestClass]
    public class Pomodor_Interruption_UnitTest
    {
        private Pomodoro _pomodoro;
        [TestInitialize]
        public void InitializePomodoro()
        {
            _pomodoro = new Pomodoro();
        }

        [TestMethod]
        public void Pomodoro_InterruptionDefault_Test()
        {
            Assert.AreEqual(true, true);
        }
        [TestMethod]
        public void Pomodoro_WithNoInterruption()
        {
            Assert.AreEqual(_pomodoro.NInterruptions, 0);
        }
        
        [TestMethod]
        public void PomodoroCanNotBeInterrptedIfNotStarted()
        {
            //ToDo
        }
        
        /*
        INTERRUPCIONES
        Un pomodoro se inicia sin interrupciones.
        Si no está arrancado no se puede interrumpir.
        El pomodoro cuenta las interrupciones (1, 2...).
         */
    }
}
