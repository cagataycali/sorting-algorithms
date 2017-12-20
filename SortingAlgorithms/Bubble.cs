﻿using System;
namespace SortingAlgorithms
{
	public class Bubble
	{
		public static void Sort(int[] arr)
		{
			int n = arr.Length;

			for (int i = 0; i < n - 1; i++)
			{
				for (int j = 0; j < n-i-1; j++)
				{
					if (arr[j] > arr[j + 1])
					{
						// Swap temp and arr[i]
						int temp = arr[j];
						arr[j] = arr[j + 1];
						arr[j + 1] = temp;
					}
				}
			}
		}
	}
}
