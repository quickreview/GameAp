using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAp
{
    internal class Character : IFighter , Itrader 
    {
        public string Name;
        public int HealthPoint;

        public int Damage;
        public int Weight;
        public int CurrentGold;


        public Character(string Name, int HealthPoint, int Damage , int Weight, int CurrentGold)
        {
            this.Name = Name;
            this.HealthPoint = HealthPoint;
            this.Damage = Damage;
            this.Weight = Weight;
            this.CurrentGold = CurrentGold;
        }

        public void Attack ( Character enemy )
        {
            enemy.HealthPoint -= Damage;
            HealthPoint -= enemy.Damage;
        }
      
        public void buyItem ( Items item ) 
        {
            if (CurrentGold >= item.cost)
            {
                CurrentGold -= item.cost;
                Damage += item.getDamageWeapon();
                HealthPoint += item.healHero();
            }
            else
            {
                MessageBox.Show("Недостаточно средств ");

            }

        }
       
    }
}
