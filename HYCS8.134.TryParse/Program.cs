using System;
using  static System.Console;
namespace HYCS8._134.TryParse
{
	class Program
	{
		static void Main(string[] args)
		{
			string value = "29/10/2020";
			DateTime dateTime;
			if (DateTime.TryParse(value,out dateTime))
			///	if (DateTime.TryParse(value, out _)) //discard _ with c#7 
				{
				WriteLine(dateTime.ToLongDateString()); 
				WriteLine(dateTime.ToShortDateString());
				WriteLine(DateTime.TryParse(value, out dateTime));
			}

			ReadKey();
		}
	}
}
