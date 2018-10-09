using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LineCnt
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int cnt = 0;
			string str0 = textBox1.Text = File.ReadAllText(@"D:\Документы\Лабораторные-работы-проц-прог\LineCnt\LineCnt\Form1.cs");
			string[] spln = str0.Split('\n');

			foreach(var spl in spln)
			{
				cnt++;
			}

			string str1 = "Число строк: ";
			label1.Text = str1 + cnt.ToString();
		}
	}
}
