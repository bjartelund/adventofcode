// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Collections.Generic;

class IncreasingValues
{
	static string[] reduce(string[] input, int pos, int value)
	{
		string[] output= new string[input.Length];
		int i=0;
		foreach (string inputvalue in input)
		{
			if ( inputvalue.Length >= pos && Int32.Parse(inputvalue[pos].ToString()) == value)
			{
				output[i++]=inputvalue;
			}
			else
				output[i++]="";
		}
		return output;
	}

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
			if (count <= lines.Length/2)
			{
				gammabinary+="0";	
				epsilonbinary+="1";	
			}
			else if (count >= lines.Length/2)
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
		int j = 0;
		string[] reduced= new string[lines.Length];
		Array.Copy(lines,reduced,lines.Length);
		foreach (char bit in gammabinary)
		{
			if (bit.ToString()!="")
			{
				reduced=reduce(reduced,j++,Int32.Parse(bit.ToString()));
			}
			int k=0;
			foreach (string number in reduced)
				
				if (number!="")
				{
					k++;
				}
			if (k==2)
				break;
		}
		Console.WriteLine(reduced.Max());
		string oxygengeneratorrating=Convert.ToInt32(reduced.Max(),2).ToString();
		Console.WriteLine(oxygengeneratorrating);
		Array.Copy(lines,reduced,lines.Length);
		j=0;
			
		foreach (char bit in epsilonbinary)
		{
			if (bit.ToString()!="")
			{
				reduced=reduce(reduced,j++,Int32.Parse(bit.ToString()));
				//Console.WriteLine(bit.ToString());
			}
			int k=0;

			foreach (string number in reduced)
			{	
				if (number!="")
				{
					k++;
					//Console.WriteLine(number);
				}
			if (k>=2)
				break;
			Console.WriteLine(k);
			}
		}
		reduced= reduced.Where(x => !string.IsNullOrEmpty(x)).ToArray();
		Console.WriteLine(reduced.Min());
		string co2scrubber=Convert.ToInt32(reduced.Min(),2).ToString();
		Console.WriteLine(co2scrubber);
		Console.WriteLine(Int32.Parse(oxygengeneratorrating)*Int32.Parse(co2scrubber));
		


	}
}

