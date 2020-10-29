using System;
using  static System.Console;
namespace HYCS8._125.GetType
{
	class Program
	{
		static void Main(string[] args)
		{
			var name = "Adem AKKUŞ";
			WriteLine(name.GetType().ToString());
			var pi = 3.14;
			WriteLine(pi.GetType().ToString());
			var decision = true;
			WriteLine(decision.GetType().ToString());
			ReadKey();
		}
	}
}
