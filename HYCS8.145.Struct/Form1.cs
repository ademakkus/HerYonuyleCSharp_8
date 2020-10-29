using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HYCS8._145.Struct
{
	public partial class Form1 : Form
	{
		public  readonly ref struct Student
		{
			public int Number { get; }
			public string Name { get; }
			public string Surname { get;  }

		
			public string ClassOf { get; }

			public Student(int number,string name,string surname,string classOf)
			{
				this.Number = number;
				this.Name = name;
				this.Surname = surname;
				this.ClassOf = classOf;

			}
		}
		public Form1()
		{
			InitializeComponent();
			var students = new Student(123,"dd","dd","11-E");
			//students.Name = "Adem";
			//students.Surname = "AKKUŞ";
			//students.ClassOf = "12-A";
			//students.Number = 123456;
			listBox1.Items.Add(students.Name);

		}
	}
}
