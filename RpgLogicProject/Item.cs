using System;
namespace RpgLogicProject
{
	public class Item
	{

		public string Name { get; set; }
		public int Weigth { get; set;}

        public Item(string name, int weigth)
        {
            Name = name;
            Weigth = weigth;
        }
    }
}

