// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

class IncreasingValues
{
	static void Main()
	{
		string[] lines = System.IO.File.ReadAllLines(@"input");
		int prev2 = -1;
		int prev1 = -1;
		int prevsum = 0;
		int increases=-1;
		int sum=0;
		foreach (string line in lines)
		{
			Console.WriteLine("\t" + line);
			int current = Int32.Parse(line);
			
			sum= current+prev1+prev2;
			Console.WriteLine(prevsum);
			if (sum > current && prevsum < sum && prev2 != -1)
			{
				Console.WriteLine("Increase");
				increases++;
			}
			prev2=prev1;
			prev1=current;
			prevsum=sum;
		}
		Console.WriteLine($"The number of increases is {increases}");

	}

}
