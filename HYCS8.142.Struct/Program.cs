using System;
using static System.Console;
namespace HYCS8._142.Struct
{
	public  class Program
	{

	public	struct Student
		{
			public string Name { get; set; }
			public string Surname { get; set; }

			public int Number { get; set; }
			public string ClassOf { get; set; }

		}
		
		static void Main(string[] args)
		{
			Student _student=new Student();
			_student.Name = "Adem";
			_student.Surname = "AKKUŞ";
			_student.ClassOf = "12-A";
			_student.Number = 123456;
			WriteLine(_student.Name);
			ReadKey();
		}
	}
}
