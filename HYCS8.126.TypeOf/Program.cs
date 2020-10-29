using System;
using static System.Console;

namespace HYCS8._126.TypeOf
{
	class Program
	{
		static void Main(string[] args)
		{

			var name = "Adem AKKUŞ";
			if (name.GetType()==typeof(string))
			{
				WriteLine("Type of name is string");
			}
		}
	}
}
