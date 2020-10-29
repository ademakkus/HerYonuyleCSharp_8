using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace HYCS8._147.Struct
{
	public partial class Form1 : Form
	{

		public struct Student
		{
			public string name;
			public string surname;

			public int number;
			public string classof;

		}

		public Form1()
		{
			InitializeComponent();
		}
		Student[] student=new Student[2];
		private byte i;
		private void button1_Click(object sender, EventArgs e)
		{
			for (int j = 0; j < student.Length-1; j++)
			{
				listBox1.Items.Add(student[i].number);
				listBox2.Items.Add(student[i].name);
				listBox3.Items.Add(student[i].surname);
				listBox4.Items.Add(student[i].classof);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < student.Length-1; i++)
			{
				student[i].number = Convert.ToInt32(Interaction.InputBox(i + ". enter number :"));
				student[i].name = Interaction.InputBox(i + "enter name :");
				student[i].surname= Interaction.InputBox(i + "enter surname :");
				student[i].classof = Interaction.InputBox(i + "enter class of  :");

			}
		}
	}
}
