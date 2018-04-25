using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;

namespace RPS.Models
{
    public class ComputerChoice
    {
        private string _rock;
        private string _paper;
        private string _scissors;
        private static List<ComputerChoice> _instances = new List<ComputerChoice> {};

        public ComputerChoice(string Rock, string Paper, string Scissors)
        {
          _rock = Rock;
          _paper = Paper;
          _scissors = Scissors;
        }
    }
}
