using System;
using  static  System.Console;
namespace HYCS8._89.ConsoleKeyInfo
{
	class Program
	{
		static void Main(string[] args)
		{

			string ad, soyad;
			Write("Adınızı giriniz: ");
			ad = ReadLine();
			Write("Soyadınızı giriniz: ");
			soyad = ReadLine();
			Clear();
			System.ConsoleKeyInfo keyiInfo = ReadKey(true);
			if (keyiInfo.Key==ConsoleKey.Escape)
			{
				System.Environment.Exit(0);
			}
			else if (keyiInfo.Key==ConsoleKey.F2)
			{
				WriteLine($"Adınız: {ad} ve soyadınız: {soyad}");
			}
			ReadKey();
		}
	}
}
