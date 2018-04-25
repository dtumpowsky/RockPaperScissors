using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;

namespace RPS.Models
{
    public class Game
    {
        private string _playersChoice;
        private string _cpu;

        public Game(string playersChoice, string cpu)
        {
          _playersChoice = playersChoice;
          _cpu = cpu;
        }

        public void SetPlayersChoice(string newPlayersChoice)
        {
            _playersChoice = newPlayersChoice;
        }
        public string GetPlayersChoice()
        {
            return _playersChoice;
        }

        public void SetComputerChoice(string newComputerChoice)
        {
            _cpu = newComputerChoice;
        }
        public string GetComputerChoice()
        {
            return _cpu;
        }



        public string GetResult()
        {
            if (_playersChoice == _cpu)
            {
                return "Tie";
            }
            else if ((_playersChoice == "rock" && _cpu == "paper") ||
                     (_playersChoice == "paper" && _cpu == "scissors") ||
                     (_playersChoice == "scissors" && _cpu == "rock"))
            {
                return "You Lose";
            }
            else
            {
                return "You Win";
            }
        }
    }
}
