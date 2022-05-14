using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAp
{
    internal class Hero : Character , Ithief
    {
      
        private int maxHealthPoint;

        public int MaxHealthPoint 
        { 
            get
            {
                return maxHealthPoint; 
            }
         
        }
      
        public Hero(string Name, int HealthPoint, int Damage , int Weight, int CurrentGold) : base (Name , HealthPoint , Damage , Weight , CurrentGold )
        {
            this.Name = Name;
            this.HealthPoint = HealthPoint;
            maxHealthPoint = HealthPoint;
            this.Damage = Damage;
            this.Weight = Weight;
            this.CurrentGold = CurrentGold;
           
        }
        public void takeItem()
        {
            CurrentGold += 20;

        }

    }
}
