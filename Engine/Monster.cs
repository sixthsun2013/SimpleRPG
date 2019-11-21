using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Monster
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int MaximumHitPoints { get; set; }

        public int CurrentHitPoints { get; set; }

        public int MaximumDamage { get; set; }

        public int RewardExpereincePoints { get; set; }

        public int RewardGold { get; set; }

    }
}
