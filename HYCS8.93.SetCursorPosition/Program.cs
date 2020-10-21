using System;
using  static  System.Console;
namespace HYCS8._93.SetCursorPosition
{
	class Program
	{
		static void Main(string[] args)
		{
			SetWindowSize(40,20);  //set the window size of console screen
			Console.SetCursorPosition(WindowWidth/2,WindowHeight/2);
			Write("Hello C#");
			ReadKey();
		}
	}
}
