Console.Clear();
Console.Write("Enter array elements separated by a space: ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = arr.Count(x => x > 0);
Console.WriteLine($"The number of positive elements in the array: {count}");