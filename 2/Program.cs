// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

class IncreasingValues
{
	static void Main()
	{
		string[] lines = System.IO.File.ReadAllLines(@"input");
		//string[] lines = System.IO.File.ReadAllLines(@"example");
		int horizontal = 0;
		int depth = 0;
		foreach (string line in lines)
		{
			string[] tokens = line.Split(" ");
			switch (tokens[0])
			{
				case "forward":
					horizontal += Int32.Parse(tokens[1]);
					break;
				case "down":
					depth += Int32.Parse(tokens[1]);
					break;
				case "up":
					depth -= Int32.Parse(tokens[1]);
					break;
				case "back":
					horizontal -= Int32.Parse(tokens[1]);
					break;

			}

		}
		Console.WriteLine("\t" + horizontal);
		Console.WriteLine("\t" + depth);
		Console.WriteLine("\t" + horizontal*depth);

	}

}
