using System;
using System.Collections.Generic;
using System.Text;

namespace GameOOP_Project.models
{
    public class Stats
    {
        public double accuracy { get; set; } = 1;
        public double damage { get; set; } = 0.2;
        public int HP { get; set; } = 8;
        public double speed { get; set; } = 0.2;

        public double calculateStats(double Levels, Stats BaseStats)
        {
            var growth_multiplier = 0.2 + (0.8 * (Levels / 100));

             HP = (int) (BaseStats.HP * growth_multiplier);

            damage = BaseStats.damage * growth_multiplier;

            speed = BaseStats.speed * growth_multiplier;

        }
    }
}
