using System.Collections.Generic;

namespace DataStructureDemo
{
	public static class Insertion
	{
		public static IEnumerable<int> InsertionSort(int[] array)
		{
			for (var index = 1; index < array.Length; index++)
			{
				var position = index;
				var tempValue = array[index];
				while (position > 0 && array[position - 1] > tempValue)
				{
					array[position] = array[position - 1];
					position = position - 1;
					array[position] = tempValue;
				}
			}

			return array;
		}
	}
}