using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;

namespace RPS.Models
{
    public class ComputerChoice
    {

        public static string[] options = {"rock", "paper", "scissors"};


        public string Choose()
        {
	        return options[new Random().Next(0,3)];
        }
    }
}
