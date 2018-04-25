using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPS.Models;
using System.Collections.Generic;
using System;

namespace RPS.Tests
{
    [TestClass]
    public class GameTests
    {

        [TestMethod]
        public void PlayGame_ReturnResult_String()
        {
          ComputerChoice newCpuPlayer = new ComputerChoice();
          string cpuChoice = newCpuPlayer.Choose();
          //public Game(string <PlayerChoice>, string <cpuChoice>)
          Console.WriteLine(cpuChoice);
          Game testPlayGame = new Game("rock", cpuChoice);
            Assert.AreEqual("You Lose", testPlayGame.GetResult());
        }

        [TestMethod]
        public void PlayGame_ComputerMakesSelection_True()
        {
          ComputerChoice newCpuPlayer = new ComputerChoice();
          string cpuChoice = newCpuPlayer.Choose();
          Assert.IsTrue(Array.IndexOf(ComputerChoice.options, cpuChoice) > -1);
        }
    }
}
