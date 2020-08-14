using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace _101_PairGame
{
    public class Player
    {
        // Points, Limbs
        public Player(int limbs, int points)
        {
            Limbs = limbs;
            Points = points;
        }

        public int Limbs { get; set; }
        public int Points { get; set; }
    }
}


