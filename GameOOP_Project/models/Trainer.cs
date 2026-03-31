using System;
using System.Collections.Generic;
using System.Text;

namespace GameOOP_Project.models
{
    public class Trainer
    {
        public string Name { get; set; }
        public List<PokeChar> Team { get; set; }
        public List<Items> Inventory { get; set; }


    }
}
