using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LE_ClassesandMEthods_StephanieLopez
{
    internal class TeamRoster<T> where T : Player
    {
        List<T> _roster = new List<T>();

        public void AddPlayer(T player)
        {
            _roster.Add(player);
        }

        public double TeamSalary()
        {
            double sum = 0;
            foreach (T playerObject in _roster)
            {
                sum += playerObject.Salary;
            }

            return sum;
        }
    }
}
