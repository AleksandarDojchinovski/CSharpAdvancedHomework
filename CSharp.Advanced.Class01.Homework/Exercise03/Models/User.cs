using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03.Models
{
    public class User
    {
        public int Score { get; set; } = 0;

        public int Draw { get; set; } = 0;

        public RPS Rps { get; set; }

        public User(int score, RPS rps, int draw)
        {
            Score = score;
            Rps = rps;
            Draw = draw;
        }
        public User()
        {

        }
    }
}
