﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PomodoroKata.Library;

namespace PomodoroKata.UnitTest
{
    [TestClass]
    public class Pomodoro_Create_UnitTest
    {
        private Pomodoro _pomodoro;
        [TestInitialize]
        public void InitializePomodoro()
        {
            _pomodoro = new Pomodoro();
        }

        [TestMethod]
        public void Pomodoro_CreateDefault_Test()
        {
            Assert.AreEqual(true, true);
        }
        /*
        CREAR UN POMODORO
        Un pomodoro dura 25 minutos por defecto.
        Puedo crear un pomodoro con cualquier duración.
        */
    }
}
