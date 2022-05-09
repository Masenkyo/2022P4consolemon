﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMon
{
    class Skill
    {
        public int damage;
        public int energyCost;
        public string name;

        void UseOn(ConsoleMon target, ConsoleMon caster)
        {
            caster.DeleteEnergy(energyCost);
            target.TakeDamage(damage);
        }
    }
}
