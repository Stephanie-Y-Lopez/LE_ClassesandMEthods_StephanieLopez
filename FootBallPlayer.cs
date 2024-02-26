using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using System.Windows.Controls;

namespace LE_ClassesandMEthods_StephanieLopez
{
    internal class FootBallPlayer : Player
    {
        int _yardsrun;

        public FootBallPlayer(string name, string number, double salary, int yardsrun) : base(name, number, salary)
        {
            _yardsrun = yardsrun;
        }

        public int Yardsrun { get => _yardsrun; set => _yardsrun = value; }

        public FootBallPlayer()
        {

        }
    }
}
