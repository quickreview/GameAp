using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAp
{
    internal class Enemy : Character
    {
        private int maxHealthPoint;
      
        public int MaxHealthPoint
        {
            get
            {
                return maxHealthPoint;
            }
        
        }

        public Enemy(string Name, int HealthPoint, int Damage, int Weight, int CurrentGold) : 
            base(Name, HealthPoint, Damage, Weight, CurrentGold)
            
        {
            this.Name = Name;
            this.HealthPoint = HealthPoint;
            this.Damage = Damage;
            maxHealthPoint = HealthPoint;

            this.Weight = Weight;
            this.CurrentGold = CurrentGold;
            
        }

      
    }
}
