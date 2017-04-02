using System;
using System.Collections.Generic;
using System.Text;
using System.IO;}

public class Hello
{
   public static void Main()
      {

		StreamReader input = new StreamReader("items.csv");
		StreamWriter output = new StreamWriter("sorted.txt");
		while (!input.EndOfStream) {
			string line = input.ReadLine();
			string[] toks = line.Split(',');
			foreach (int value in values) {
				output.Write(value + " ");
}
	output.WriteLine();
			input.Close();
			output.Close();
		}
}
	
