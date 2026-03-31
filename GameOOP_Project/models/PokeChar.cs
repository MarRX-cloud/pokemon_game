using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace GameOOP_Project.models
{
    
    public class PokeChar
    {
        public required name{get; set; }
        public required List<Attacks> Attacks { get; set; }
        public required Type Type { get; set; }
        public required Stats CurrentStats { get; set; }
        public double Levels { get; set; }
        public required Stats BaseStats { get; set; }

    }
}
