using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_LinearSearch
{
    internal class GameConsole
    {
        public string ConsoleName { get; set; }
        public string ConsoleGame {  get; set; }
        public string Company { get; set; }

        public GameConsole(string consoleName, string consoleGame, string company)
        {
            ConsoleName = consoleName;
            ConsoleGame = consoleGame;
            Company = company;
        }
    }
}
