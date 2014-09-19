using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonCombatSimulatorV2
{
    public enum AttackType { Judo = 1, Teeth, MoJo }
    class Player
    {

        private int _hp;

        public int HP
        {
            get { return _hp; }
            set { _hp = value; }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        //readonly  property for IsAlive
        public bool IsAlive
        {
            get { return this.HP > 0; }
        }

        // Create a random number generator 
        private Random rng = new Random();

        public Player(string name, int startingHP)
        {
            this.Name = name; this.HP = startingHP;
        }

        private AttackType ChooseAttack()
        {
            Console.WriteLine(@"
Choose Attack:
Judo Chop
Crooked Teeth Smile
Increase your MoJo");

            //get input from user
            int input = int.Parse(Console.ReadLine());
            // return the correct AttackType
            return (AttackType)input;
        }
        public void Attack(Samurai_Yuri enemy)
        {
            // use a SWITCH statement to perform the attack
            int damage;
            switch (ChooseAttack())
            {
                case AttackType.Judo:
                    // 70% chance to hit
                    if (rng.Next(0, 11) > 3)
                    {
                        damage = rng.Next(15, 31);
                        //deal damge to enemy
                        enemy.HP -= damage;
                        // write output to the user
                        Console.WriteLine("{0} deals {1} delt damage to {2}JUDO CHOP!!", this.Name, damage, enemy.Name);
                    }
                    else 
                    {
                        Console.WriteLine("{0} missed {1} with the Judo Chop!", this.Name, enemy.Name);
                    }

                    break;
                case AttackType.Teeth:
                    damage = rng.Next(5, 16);
                    enemy.HP -= damage;
                    Console.WriteLine("{0} deals {1} delt damage to {2} with the grossest looking teeth ever seen.", this.Name, damage, enemy.Name);
                    break;
                case AttackType.MoJo:
                    // heals for 10 - 20
                    int amountToHealPlayer = rng.Next(10, 21);
                    this.HP += amountToHealPlayer;
                    Console.WriteLine("{0} was healed for {1} HP. Yeah baby Yeah!", this.Name, amountToHealPlayer);
                    break;
                default:
                    break;
            }
        

        }
    }
}
