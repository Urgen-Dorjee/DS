using System;
using System.Collections.Generic;

namespace DataStructureDemo
{
	public static class GenericSelectionSort 
	{
		public static void Sort<T>(T[] array) where T : IComparable
		{
			for (var i = 0; i < array.Length - 1; i++)
			{
				var minIndex = i;
				var minValue = array[i];

				for (var j = i + 1; j < array.Length; j++)
				{
					if (array[j].CompareTo(minValue) < 0)
					{
						minIndex = j;
						minValue = array[j];
					}
				}

				Swap(array, i, minIndex);
			}

		}

		private static void Swap<T>(IList<T> array, int first, int second)
		{
			var temp = array[first];
			array[first] = array[second];
			array[second] = temp;
		}
	}
}