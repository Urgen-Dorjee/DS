using System;

namespace DataStructureDemo
{
	public static class SearchForDuplicate
	{
		//This code, which contains nested loops, runs at O(N2)
		public static bool CountDuplicate(int[] array)
		{
			int step = 0;
			for (var i = 0; i < array.Length; i++)
			{
				for (var j = 0; j < array.Length; j++)
				{
					step++;
					if (i != j && array[i] == array[j])
					{
						return true;
					}
				}
			}
			Console.WriteLine($"Number of Step: {step}");
			return false;
		}

		//This section of code runs at O(N)
		public static bool HasDuplicateValue(int[] array)
		{
			var step = 0;
			var existingNumbers = new int[]{};
			for (var i = 0; i < array.Length; i++)
			{
				step++;
				if (existingNumbers[array[i]] == array[i])
				{
					existingNumbers[array[i]] = 1;
				}
				else
				{
					return true;
				}
			}

			Console.WriteLine($"Step: {step}");

			return false;
		}
	}
}