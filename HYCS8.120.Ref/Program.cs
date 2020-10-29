using System;

namespace HYCS8._120.Ref
{
	class Program
	{
		static void Main(string[] args)
		{
			string message = "This message is created by main program";
			Console.WriteLine(message);
			WriteMessageMethod(ref message);
			Console.ForegroundColor = ConsoleColor.DarkBlue;
			Console.WriteLine(message);
			Console.ReadKey();
		}
		
		private static void WriteMessageMethod(ref string message)
		{
			message = "This message is created by WriteMessageMethod method";
		}
	}
}
