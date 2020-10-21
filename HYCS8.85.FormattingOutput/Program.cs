using System;
using  static  System.Console;
namespace HYCS8._85.FormattingOutput
{
	class Program
	{
		static void Main(string[] args)
		{
			Write("Adınızı giriniz:");
			string ad = ReadLine();
			Write("Soyadınızı giriniz: ");
			string soyad = ReadLine();

			Write("Yaşınızı giriniz: ");
			int yas = Convert.ToInt32(ReadLine());
			WriteLine("Adınız |{0,-10}| Soyadınız |{1,4}|Yaşınız |{2,10}",ad,soyad,yas);  //{0,-10} sola doğru hizalar
																																										//{0,10} sağa hizalar
			ReadKey();
		}
	}
}
