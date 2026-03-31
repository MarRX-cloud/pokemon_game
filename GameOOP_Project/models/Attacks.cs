using System;
using System.Collections.Generic;
using System.Text;

namespace GameOOP_Project.models
{
    public class Attacks
    {
        public required string name {  get; set; }
        public decimal damage { get; set; }
        public double accuracy { get; set; } = 90.0;
        public required Type type { get; set; }
        public int MovesLeft { get; set; } = 12;


    }
}
