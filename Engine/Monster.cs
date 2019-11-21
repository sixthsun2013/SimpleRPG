﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Monster : LivingCreature
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int MaximumDamage { get; set; }

        public int RewardExpereincePoints { get; set; }

        public int RewardGold { get; set; }

    }
}
