using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ScoreBoard_
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			try
			{
				t1namebox.Text = read("T1Name.txt");
				t1scorebox.Text = read("T1Score.txt");
				t2namebox.Text = read("T2Name.txt");
				t2scorebox.Text = read("T2Score.txt");
			}catch{
				MessageBox.Show("Failed to read data. Ignore if first run.");
			}
			try
			{
				quarterbox.Value = Int32.Parse(read("Quarter.txt"));
			}catch{
				MessageBox.Show("Couldn't read Quarter.txt properly. Ignore if first run.");
			}
			
		}
		public void write(string filenm, string output)
		{
			StreamWriter file = new StreamWriter(filenm);
			file.WriteLine(output);
			file.Close();
		}
		public string read(string filenm)
		{
			StreamReader file = new StreamReader(filenm);
			return file.ReadToEnd();
		}
		
		void UpdatebuttonClick(object sender, EventArgs e)
		{
			write("T1Name.txt", t1namebox.Text);
			write("T1Score.txt", t1scorebox.Text);
			write("T2Name.txt", t2namebox.Text);
			write("T2Score.txt", t2scorebox.Text);
			write("Quarter.txt", quarterbox.Value.ToString());
		}
		void LockboxCheckedChanged(object sender, EventArgs e)
		{
			if(lockbox.Checked)
			{
				t1namebox.Enabled = false;
				t2namebox.Enabled = false;
				quarterbox.Enabled = false;
			}else{
				t1namebox.Enabled = true;
				t2namebox.Enabled = true;
				quarterbox.Enabled = true;
			}
		}
	}
}
