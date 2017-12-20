using System;
namespace SortingAlgorithms
{
	public class ReverseBubble
	{
		public static void Sort(int[] arr, int n)
		{
			if (n == 1)
				return;

			/*
				One pass of bubble sort, after this pass
				the largest element is moved (bubbled) to end.
			*/
			for (int i = 0; i < n-1; i++)
				if (arr[i] > arr[i + 1])
				{
					// Swap arr[i], arr[i + 1]
					int temp = arr[i];
					arr[i] = arr[i + 1];
					arr[i + 1] = temp;
				}
			Sort(arr, n - 1);
		}
	}
}
