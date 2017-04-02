using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

public class Hello
{
   public static void Main(string[] args)
   {

		StreamReader input = new StreamReader(args[0]);
		List<string []> students = new List<string []> ();

		while (!input.EndOfStream) {
			string student = input.ReadLine();
			string[] fields = student.Split('\t');

			if(File.Exists(args[1])){
			    File.Delete(args[1]);
			}

			File.Copy(args[1],fields[1]);
			string studentFile = File.ReadAllText(args[1]); 

			foreach (String field in fields) {
				studentFile.Replace("<<NAME>>", fields[0]);
				studentFile.Replace("<<COURSE>>", fields[2]);
				studentFile.Replace("<<ID>>", fields[1]);
				studentFile.Replace("<<TOTAL>>", fields[12]);
				studentFile.Replace("<<SUBTOTAL>>", fields[11]);
				studentFile.Replace("<<LATEDEDUCTIONS>>", fields[6]);
				studentFile.Replace("<<DUE>>", fields[0]);
				studentFile.Replace("<<SUBMITTED>>", fields[4]);
				studentFile.Replace("<<MINUTESLATE>>", fields[5]);
				studentFile.Replace("<<P1>>", fields[7]);
				studentFile.Replace("<<P1COMMENTS>>", fields[8]);
				studentFile.Replace("<<P2>>", fields[9]);
				studentFile.Replace("<<P2COMMENTS>>", fields[10]);

			}
		
		Console.WriteLine(studentFile);
		File.WriteAllText(args[1], studentFile);
		}
	input.Close();
		
	}	
}
