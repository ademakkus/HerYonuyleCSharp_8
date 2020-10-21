using System;
using static System.Console;
namespace HYCS8._100.ProgramConstructor
{
	class Program
	{
		static void Main(string[] args)
		{
			Program program=new Program();

			ReadKey();
		}

		private readonly DateTime dateTime;

		public Program()
		{
			string ad = "Adem";
			string soyad = "AKKUŞ";
				dateTime=DateTime.Now;
				WriteLine("Aşağıdaki bilgiler constructor ile alındı:");
				ForegroundColor = ConsoleColor.Green;
				WriteLine($"Bu program adınız :{ad} ve soyadınız :{soyad}");
					WriteLine(dateTime);
		}
	}
}
