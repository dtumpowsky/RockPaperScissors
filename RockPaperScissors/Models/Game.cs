using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;

namespace RPS.Models
{
    public class Game
    {
        private PlayersCoice _playersChoice;
        private ComputerChoice _cpu;
        private string _youWin;
        private string _youLose;

        public Game(string NewPlayerChoice, string NewComputerChoice, string NewYouWin, string NewYouLose)

        _playersChoice = NewPlayerChoice
        _cpu = NewComputerChoice
        _youWin = NewYouWin
        _youLose = NewYouLose
        }


        public void PlayGame()
        {
            return(new Random().GetProperty(_cpu);
        }
        public void SetWin()
        {

        }
    }
}
