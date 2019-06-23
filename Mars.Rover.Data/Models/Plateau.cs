using System;
using System.Collections.Generic;
using System.Text;

namespace Mars.Rover.Data.Models
{
    public class Plateau
    {
        public int UpperRight { get; set; }
        public int LowerLeft { get; set; }

        public Plateau()
        {
            UpperRight = 0;
            LowerLeft = 0;
        }

        public Plateau(int upperRight, int lowerLeft)
        {
            UpperRight = upperRight;
            LowerLeft = lowerLeft;
        }

   
    }
}
