using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;

namespace RPS.Models
{
    public class PlayerChoice
    {
        private string _rock;
        private string _paper;
        private string _scissors;
        // private ComputerChoice _cpu;

        public PlayerChoice(string Rock, string Paper, string Scissors)
        {
          _rock = Rock;
          _paper = Paper;
          _scissors = Scissors;
        }

        public void SetRock(string selectRock)
        {
            _rock = selectRock;
        }

        public string GetRock()
        {
            return _rock;
        }

        public void SetPaper(string selectPaper)
        {
            _paper = selectPaper;
        }

        public string GetPaper()
        {
            return _paper;
        }

        public void SetScissors(string selectScissors)
        {
            _scissors = selectScissors;
        }

        public string GetScissors()
        {
            return _scissors;
        }

        // public void PlayGame()
        // {
        //     int randomNumber=new Random().Next();
        // }
    }
}
