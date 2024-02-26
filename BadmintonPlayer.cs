using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LE_ClassesandMEthods_StephanieLopez
{
    internal class BadmintonPlayer : Player
    {
        int _hits;

        public BadmintonPlayer(string name, string number, double salary, int hits) : base(name, number, salary)
        {
            _hits = hits;
        }

        public int Hits { get => _hits; set => _hits = value; }

        public BadmintonPlayer()
        {

        }
    }
}
