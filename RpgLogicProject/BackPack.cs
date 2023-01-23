using System;
namespace RpgLogicProject
{
	public class BackPack
	{
		private readonly Item[] items;

		public int maxWeigth { get; set; }

		public BackPack(int count)
		{
			items = new Item[count];
		}

		public void Add(Item item, int index)
		{
			//Добавление элемента в массив
		}

		public void Remove(int index)
		{
			//Удаление элемента из массива.
		}

		public int GetWeigth() {

			// Вычислить текуший вес рюкзака
			return 0;
		}


	}
}

