using System.Collections.Generic;

namespace DataStructureDemo
{
	public static class BubbleSorting
	{
		public static IEnumerable<int> BubbleSort(int[] arr)
		{
			var unsortedIndex = arr.Length - 1;
			var sorted = false;

			while (sorted == false)
			{
				for (var i = 0; i < unsortedIndex; i++)
				{
					sorted = true;
					for (var j = 0; j < unsortedIndex - i - 1; j++)
					{
						if (arr[j] > arr[j + 1])
						{
							var temp = arr[j];
							arr[j] = arr[j + 1];
							arr[j + 1] = temp;
							sorted = false;
						}
					}
				}
			}

			return arr;
		}
	}
}