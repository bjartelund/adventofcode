// See https://aka.ms/new-console-template for more information

string input = "3,4,3,1,2";
//string input = "1,1,1,3,3,2,1,1,1,1,1,4,4,1,4,1,4,1,1,4,1,1,1,3,3,2,3,1,2,1,1,1,1,1,1,1,3,4,1,1,4,3,1,2,3,1,1,1,5,2,1,1,1,1,2,1,2,5,2,2,1,1,1,3,1,1,1,4,1,1,1,1,1,3,3,2,1,1,3,1,4,1,2,1,5,1,4,2,1,1,5,1,1,1,1,4,3,1,3,2,1,4,1,1,2,1,4,4,5,1,3,1,1,1,1,2,1,4,4,1,1,1,3,1,5,1,1,1,1,1,3,2,5,1,5,4,1,4,1,3,5,1,2,5,4,3,3,2,4,1,5,1,1,2,4,1,1,1,1,2,4,1,2,5,1,4,1,4,2,5,4,1,1,2,2,4,1,5,1,4,3,3,2,3,1,2,3,1,4,1,1,1,3,5,1,1,1,3,5,1,1,4,1,4,4,1,3,1,1,1,2,3,3,2,5,1,2,1,1,2,2,1,3,4,1,3,5,1,3,4,3,5,1,1,5,1,3,3,2,1,5,1,1,3,1,1,3,1,2,1,3,2,5,1,3,1,1,3,5,1,1,1,1,2,1,2,4,4,4,2,2,3,1,5,1,2,1,3,3,3,4,1,1,5,1,3,2,4,1,5,5,1,4,4,1,4,4,1,1,2";
string[] inputstrarray= input.Split(",");
int[] inputarray= new int[inputstrarray.Length];
int i=0;

foreach (string inputnumber in inputstrarray)
	inputarray[i++]=Int32.Parse(inputnumber);


static int[] iterate(int[] inputarray)
{
	int spawn=0;
	int i=0;
	foreach (int number in inputarray)
	{
		if (number == 0)
			spawn++;
	}
	int[] outputarray= new int[inputarray.Length+spawn];
	foreach (int number in inputarray)
	{
		if (number <= 6)
			outputarray[i++] = ((number-1 % 7)+7)%7;
		else
			outputarray[i++] = number - 1;
	}
	while (spawn >= 1)
	{
		outputarray[i++]=8;
		spawn--;
	}
	return outputarray;
}
i=1;
int[] outputarray= iterate(inputarray);
while (i !=150)
{
	outputarray= iterate(outputarray);
	//Console.WriteLine(String.Join(",",outputarray));
i++;
}
Console.WriteLine(i);
Console.WriteLine(outputarray.Length);
//int sum=0;
//foreach (int number in outputarray)
//	sum+=number;
//Console.WriteLine(sum);
