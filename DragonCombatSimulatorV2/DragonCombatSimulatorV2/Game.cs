using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonCombatSimulatorV2
{
    class Game
    {
        public Player Player { get; set; }
        public Samurai_Yuri Enemy { get; set; }

        public Game()
        {
            this.Player = new Player("Austin Powers", 100);
            this.Enemy = new Samurai_Yuri("Sexy Samurai", 200);
        }
        private void DisplayInfo() 
        {
            Console.WriteLine("{0} {1}HP vs {2} {3}HP", Player.Name, Player.HP, Enemy.Name, Enemy.HP);

        }
        public void Play() 
        {
        // playing while both are ALIVE
            while (Player.IsAlive && Enemy.IsAlive) 
            {
                DisplayInfo();
                Player.Attack(Enemy);
                Enemy.Attack(Player);
            }
            if (!Player.IsAlive)
            {
                Console.WriteLine("{0} your randieness has gotten the best of you Mr. Powers!", this.Player.Name);
            }
            else 
            {
                Console.WriteLine("{0} Austin's sexiness was to much for the sexy samurai!", this.Enemy.Name);

            }
            
        }
    }
}
