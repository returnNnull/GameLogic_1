using System;
namespace RpgLogicProject
{
	public class Enemy
	{
        public string Name { get; set; }
        public int Level { get; set; }
        public double Damage { get; private set; }
        public double Hp { get; set; }

        //Добавить оружие или броню

        public Enemy(string name, int level, double hp)
        {
            Name = name;
            Level = level;
            Hp = hp;
            Damage = 1.1 * Level;
        }
    }
}

