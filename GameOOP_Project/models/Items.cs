using System;
using System.Collections.Generic;
using System.Text;

namespace GameOOP_Project.models
{
    public class Items
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Action<Char> Effect { get; set; }

    }
}
