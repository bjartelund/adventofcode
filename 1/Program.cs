// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

class IncreasingValues
{
	static void Main()
	{
		string[] lines = System.IO.File.ReadAllLines(@"input");
		int prev = -1;
		int increases=0;
		foreach (string line in lines)
		{
			Console.WriteLine("\t" + line);
			int current = Int32.Parse(line);
			if (prev < current && prev != -1)
			{
				Console.WriteLine("Increase");
				increases++;
			}

			prev=current;
		}
		Console.WriteLine($"The number of increases is {increases}");

	}

}
