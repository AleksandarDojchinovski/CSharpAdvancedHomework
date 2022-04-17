using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03.Models
{
    public class Computer
    {
        public int Score { get; set; } = 0;

        public RPS Rps { get; set; }

        public Computer(int score, RPS rps)
        {
            Score = score;
            Rps = rps;
        }
        public Computer()
        {

        }
    }
}
