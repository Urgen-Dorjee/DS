using System;
using System.Collections.Generic;

namespace DataStructureDemo
{
	public static class SelectionSort
	{
		public static IEnumerable<int> SelectionSorting(int[] array)
		{
			var step = 0;
			var swap = 0;
			for (var i = 0; i < array.Length; i++)
			{
				var lowestNumber = i;
				for (var j = i + 1; j < array.Length; j++)
				{
					if (array[j] < array[lowestNumber])
					{
						lowestNumber = j;
						swap++;
					}
					step++;
				}
				if (lowestNumber != i)
				{
					var temp = array[i];
					array[i] = array[lowestNumber];
					array[lowestNumber] = temp;
				}
			}

			Console.WriteLine($"{step} Comparison and {swap} Swaps");

			return array;
		}
	}
}