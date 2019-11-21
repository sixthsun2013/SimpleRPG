using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Weapon : Item
    {
        public Weapon(int iD, string name, string namePlural, int minimumDamage, int maximumDamage) : base(iD, name, namePlural)
        {
            MinimumDamage = minimumDamage;
            MaximumDamage = maximumDamage;
        }

        public int MinimumDamage { get; set; }

        public int MaximumDamage { get; set; }
    }
}
