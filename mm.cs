using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

public class hmwk04
{
   public static void Main(string[] args)
   {

		StreamReader input = new StreamReader(args[0]);
		input.ReadLine();
		
		while (!input.EndOfStream) {
			string student = input.ReadLine();
			string[] fields = student.Split('\t');

			if(File.Exists(fields[1])){
			    File.Delete(fields[1]);
			}

			File.Copy(args[1],fields[1]);
			string studentFileStr = File.ReadAllText(args[1]); 
			StringBuilder studentFileBldr = new StringBuilder(studentFileStr);
			
			studentFileBldr.Replace("<<NAME>>", fields[0]);
			studentFileBldr.Replace("<<COURSE>>", fields[2]);
			studentFileBldr.Replace("<<ID>>", fields[1]);
			studentFileBldr.Replace("<<TOTAL>>", fields[12]);
			studentFileBldr.Replace("<<SUBTOTAL>>", fields[11]);
			studentFileBldr.Replace("<<LATEDEDUCTION>>", fields[6]);
			studentFileBldr.Replace("<<DUE>>", fields[3]);
			studentFileBldr.Replace("<<SUBMITTED>>", fields[4]);
			studentFileBldr.Replace("<<MINUTESLATE>>", fields[5]);
			studentFileBldr.Replace("<<P1>>", fields[7]);
			studentFileBldr.Replace("<<P1COMMENTS>>", fields[8]);
			studentFileBldr.Replace("<<P2>>", fields[9]);
			studentFileBldr.Replace("<<P2COMMENTS>>", fields[10]);
		
			//Console.WriteLine(studentFile);
			File.WriteAllText(fields[1], studentFileBldr.ToString());
		}
	input.Close();
		
	}	
}
