using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMon
{
    class ConsoleMon
    {
        public int health;
        public int energy;
        public string name;

        public void TakeDamage(int damage)
        {
            health -= damage;
        }
        public void DeleteEnergy(int energy)
        {
            this.energy -= energy;
        }
    }
}