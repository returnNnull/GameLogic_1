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

            //Реализовать пошаговый бой до окончании жизни
            //одного из участников битвы
        }
    }

   
}

