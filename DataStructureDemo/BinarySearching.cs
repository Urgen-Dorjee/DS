namespace DataStructureDemo
{
	public static class BinarySearching
	{
		public static int BinarySearch(int[] binaryNumbers, int value)
		{
			var lowerBound = 0;
			var upperBound = binaryNumbers.Length - 1;

			do
			{
				var middle = (upperBound + lowerBound) / 2;
				var middleValue = binaryNumbers[middle];
				if (value < middleValue)
				{
					upperBound = middle - 1;
				}
				else if (value > middleValue)
				{
					lowerBound = middle + 1;
				}
				else if (value == middleValue)
				{
					return middle;
				}

			} while (lowerBound <= upperBound);

			return 0;
		}
	}
}