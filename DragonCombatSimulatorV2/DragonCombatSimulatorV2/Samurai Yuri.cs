using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonCombatSimulatorV2
{
    class Samurai_Yuri
    {
         private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value.ToUpper(); }
        }
        private int _hp;

        public int HP
        {
            get { return _hp; }
            set { _hp = value; }
        }
       private Random rng = new Random();
        public Samurai_Yuri (string name, int startingHP) 
        {
            this.HP = startingHP;
            this.Name = name;
        }
        public bool IsAlive
        {
            get { return this.HP > 0; }
        }
        public void Attack(Player player)
        {
            if (rng.Next(0, 11) > 2) 
            {

                int damage = rng.Next(5, 16);
                // we will hit the player for damage
                player.HP -= damage;
                // write the console to the user
                Console.WriteLine("{0} hit {1}for {2} damage", this.Name,player.Name,damage);
            }
            else
            {
                Console.WriteLine("{0} missed {1} ", this.Name,player.Name);
            }
        }
    }
}
