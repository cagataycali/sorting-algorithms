using System;

namespace SortingAlgorithms
{
	class MainClass
	{
		public static void display(int[] arr) 
		{
			for (int i = 0; i < arr.Length; i++)
				Console.WriteLine(arr[i]);
		}

		public static void Main(string[] args)
		{
			int[] arr = { 12, 3, 8, 5, 15, 12, 45, 31 };

			display(arr);
			//Selection.Sort(arr);
			//Insertion.Sort(arr);
			Console.WriteLine("---");
			//Bubble.Sort(arr);
			display(arr);
		}
	}
}
