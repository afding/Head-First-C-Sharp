using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketballRoster.Model
{
    class Player
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public bool Starter { get; set; }

        public Player(string name, int number, bool starter)
        {
            Name = name;
            Number = number;
            Starter = starter;
        }
    }
}
