using System;

namespace DataStructureDemo
{
	public class LinearSearching
	{
		public static int LinearSearch(int[] numbers, int value)
		{
			var step = 0;
			for (var i = 0; i < numbers.Length; i++)
			{
				step++;
				var index = i;
				if (numbers[i] == value)
				{
					Console.WriteLine($"Steps to find the value: {step}");
					Console.WriteLine($"Value located at index : {index}");
					return value;
				}
			}

			return 0;
		}
	}
}