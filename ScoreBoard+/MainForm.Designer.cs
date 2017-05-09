namespace ScoreBoard_
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox team1box;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox t1scorebox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox t1namebox;
		private System.Windows.Forms.GroupBox team2box;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox t2scorebox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox t2namebox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.NumericUpDown quarterbox;
		private System.Windows.Forms.Button updatebutton;
		private System.Windows.Forms.CheckBox lockbox;
		private System.Windows.Forms.PictureBox pictureBox1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.team1box = new System.Windows.Forms.GroupBox();
			this.t1scorebox = new System.Windows.Forms.TextBox();
			this.t1namebox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.team2box = new System.Windows.Forms.GroupBox();
			this.t2scorebox = new System.Windows.Forms.TextBox();
			this.t2namebox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.quarterbox = new System.Windows.Forms.NumericUpDown();
			this.updatebutton = new System.Windows.Forms.Button();
			this.lockbox = new System.Windows.Forms.CheckBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.team1box.SuspendLayout();
			this.team2box.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.quarterbox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Open Sans", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(84, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(310, 58);
			this.label1.TabIndex = 0;
			this.label1.Text = "ScoreBoard+";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(161, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(221, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "github.com/jacklsovakia";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// team1box
			// 
			this.team1box.Controls.Add(this.t1scorebox);
			this.team1box.Controls.Add(this.t1namebox);
			this.team1box.Controls.Add(this.label5);
			this.team1box.Controls.Add(this.label3);
			this.team1box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.team1box.Location = new System.Drawing.Point(12, 93);
			this.team1box.Name = "team1box";
			this.team1box.Size = new System.Drawing.Size(215, 146);
			this.team1box.TabIndex = 0;
			this.team1box.TabStop = false;
			this.team1box.Text = "Team 1";
			// 
			// t1scorebox
			// 
			this.t1scorebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.t1scorebox.Location = new System.Drawing.Point(6, 103);
			this.t1scorebox.Name = "t1scorebox";
			this.t1scorebox.Size = new System.Drawing.Size(203, 26);
			this.t1scorebox.TabIndex = 2;
			// 
			// t1namebox
			// 
			this.t1namebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.t1namebox.Location = new System.Drawing.Point(6, 48);
			this.t1namebox.Name = "t1namebox";
			this.t1namebox.Size = new System.Drawing.Size(203, 26);
			this.t1namebox.TabIndex = 0;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(6, 81);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 19);
			this.label5.TabIndex = 1;
			this.label5.Text = "Score";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(6, 26);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 19);
			this.label3.TabIndex = 1;
			this.label3.Text = "Name";
			// 
			// team2box
			// 
			this.team2box.Controls.Add(this.t2scorebox);
			this.team2box.Controls.Add(this.t2namebox);
			this.team2box.Controls.Add(this.label6);
			this.team2box.Controls.Add(this.label4);
			this.team2box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.team2box.Location = new System.Drawing.Point(251, 93);
			this.team2box.Name = "team2box";
			this.team2box.Size = new System.Drawing.Size(215, 146);
			this.team2box.TabIndex = 1;
			this.team2box.TabStop = false;
			this.team2box.Text = "Team2";
			// 
			// t2scorebox
			// 
			this.t2scorebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.t2scorebox.Location = new System.Drawing.Point(6, 103);
			this.t2scorebox.Name = "t2scorebox";
			this.t2scorebox.Size = new System.Drawing.Size(203, 26);
			this.t2scorebox.TabIndex = 3;
			// 
			// t2namebox
			// 
			this.t2namebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.t2namebox.Location = new System.Drawing.Point(6, 48);
			this.t2namebox.Name = "t2namebox";
			this.t2namebox.Size = new System.Drawing.Size(203, 26);
			this.t2namebox.TabIndex = 1;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(6, 81);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 19);
			this.label6.TabIndex = 1;
			this.label6.Text = "Score";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(6, 26);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 19);
			this.label4.TabIndex = 1;
			this.label4.Text = "Name";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(12, 265);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 18);
			this.label7.TabIndex = 3;
			this.label7.Text = "Quarter";
			// 
			// quarterbox
			// 
			this.quarterbox.Location = new System.Drawing.Point(79, 263);
			this.quarterbox.Maximum = new decimal(new int[] {
			4,
			0,
			0,
			0});
			this.quarterbox.Minimum = new decimal(new int[] {
			1,
			0,
			0,
			0});
			this.quarterbox.Name = "quarterbox";
			this.quarterbox.Size = new System.Drawing.Size(48, 26);
			this.quarterbox.TabIndex = 4;
			this.quarterbox.Value = new decimal(new int[] {
			1,
			0,
			0,
			0});
			// 
			// updatebutton
			// 
			this.updatebutton.Location = new System.Drawing.Point(317, 257);
			this.updatebutton.Name = "updatebutton";
			this.updatebutton.Size = new System.Drawing.Size(149, 33);
			this.updatebutton.TabIndex = 6;
			this.updatebutton.Text = "Update";
			this.updatebutton.UseVisualStyleBackColor = true;
			this.updatebutton.Click += new System.EventHandler(this.UpdatebuttonClick);
			// 
			// lockbox
			// 
			this.lockbox.Location = new System.Drawing.Point(133, 266);
			this.lockbox.Name = "lockbox";
			this.lockbox.Size = new System.Drawing.Size(88, 24);
			this.lockbox.TabIndex = 5;
			this.lockbox.Text = "Lock";
			this.lockbox.UseVisualStyleBackColor = true;
			this.lockbox.CheckedChanged += new System.EventHandler(this.LockboxCheckedChanged);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 17);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(84, 70);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// MainForm
			// 
			this.AcceptButton = this.updatebutton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(478, 302);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.lockbox);
			this.Controls.Add(this.updatebutton);
			this.Controls.Add(this.quarterbox);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.team2box);
			this.Controls.Add(this.team1box);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "ScoreBoard+";
			this.TopMost = true;
			this.team1box.ResumeLayout(false);
			this.team1box.PerformLayout();
			this.team2box.ResumeLayout(false);
			this.team2box.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.quarterbox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
