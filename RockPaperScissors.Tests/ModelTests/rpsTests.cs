using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPS.Models;
using System.Collections.Generic;
using System;

namespace RPS.Tests
{
    [TestClass]
    public class PlayerChoiceTests
    {

        [TestMethod]
        public void ChooseRock_ReturnRock_String()
        {
            PlayerChoice testGetRock = new PlayerChoice("rock", "paper", "scissors");

            Assert.AreEqual("rock", testGetRock.GetRock());
        }
    }
}
