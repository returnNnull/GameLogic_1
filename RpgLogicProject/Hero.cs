using System;
namespace RpgLogicProject
{
	public class Hero
	{
		public string Name { get; set; }
		public int Level { get; set; }
		public double Damage{ get;private set;}
		public double Hp { get; set;}

        //Добавить оружие или броню

        public Hero(string name, int level, double hp)
        {
            Name = name;
            Level = level;
            Hp = hp;
            Damage = 1.1 * Level;
        }
    }
}

