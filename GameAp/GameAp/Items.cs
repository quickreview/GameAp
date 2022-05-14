using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAp
{
    class Items : IWeapon , Ihealer 
    {
        
        public int cost;
        public int damage;
        public int heal; 

        public Items ( int cost , int damage , int heal )
        {
          
            this.cost = cost;
            this.damage = damage;
            this.heal = heal; 
        }

        public int getDamageWeapon( )
        {
            return damage; 
        }
        public int healHero(   )
        {
            return heal; 
        }

        
      

    }
}
