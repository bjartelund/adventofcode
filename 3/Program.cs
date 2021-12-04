// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Collections.Generic;

class IncreasingValues
{
	static void Main()
	{
		string[] lines = System.IO.File.ReadAllLines(@"input");
		//string[] lines = System.IO.File.ReadAllLines(@"example");
		int[] counts = new int[lines[0].Length];
		int i;
		Console.WriteLine(lines.Length);
		foreach (string line in lines)
		{
			i=0;
			foreach (char c in line)
			{
			counts[i++]+=Int32.Parse(c.ToString());
			}

		}
		string gammabinary="";
		string epsilonbinary="";
		foreach (int count in counts)
		{
			if (count < lines.Length/2)
			{
				gammabinary+="0";	
				epsilonbinary+="1";	
			}
			else if (count > lines.Length/2)
			{
				gammabinary+="1";	
				epsilonbinary+="0";	
			}
		}
		Console.WriteLine(gammabinary);
		Console.WriteLine(epsilonbinary);
		string gammadecimal=Convert.ToInt32(gammabinary,2).ToString();
		string epsilondecimal=Convert.ToInt32(epsilonbinary,2).ToString();
		Console.WriteLine(gammadecimal);
		Console.WriteLine(epsilondecimal);
		Console.WriteLine(Int32.Parse(gammadecimal)*Int32.Parse(epsilondecimal));


	}
}

