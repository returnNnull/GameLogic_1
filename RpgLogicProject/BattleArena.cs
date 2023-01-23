using System;
namespace RpgLogicProject
{
	public class BattleArena
	{
		public Enemy Enemy { get; set; }
		public Hero Hero { get; set; }

        public BattleArena(Enemy enemy, Hero hero)
        {
            Enemy = enemy;
            Hero = hero;
        }


        public void Battle() {

            //Изменить логику в соответствии с модификаторами оружия или брони
            while (true)
            {
                if (Enemy.Hp > 0)
                {
                    Enemy.Hp -= Hero.Damage;
                }
                else
                {
                    Console.WriteLine("Hero is win!");
                    break;
                   
                }


                if (Hero.Hp > 0)
                {
                    Hero.Hp -= Enemy.Damage;
                }
                else
                {
                    Console.WriteLine("Hero is lose");
                    break;
                }
            }
           
           

        }
    }
}

