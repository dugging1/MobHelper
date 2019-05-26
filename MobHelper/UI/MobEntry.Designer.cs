namespace MobHelper.UI {
	partial class MobEntry {
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.button1 = new System.Windows.Forms.Button();
			this.AC = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.mobNumber = new System.Windows.Forms.TextBox();
			this.mobType = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.Str = new System.Windows.Forms.TextBox();
			this.Dex = new System.Windows.Forms.TextBox();
			this.Int = new System.Windows.Forms.TextBox();
			this.Wis = new System.Windows.Forms.TextBox();
			this.Con = new System.Windows.Forms.TextBox();
			this.Cha = new System.Windows.Forms.TextBox();
			this.Hp = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.button1);
			this.splitContainer1.Panel1.Controls.Add(this.AC);
			this.splitContainer1.Panel1.Controls.Add(this.label8);
			this.splitContainer1.Panel1.Controls.Add(this.mobNumber);
			this.splitContainer1.Panel1.Controls.Add(this.mobType);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
			this.splitContainer1.Size = new System.Drawing.Size(397, 74);
			this.splitContainer1.SplitterDistance = 25;
			this.splitContainer1.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Black;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
			this.button1.Location = new System.Drawing.Point(341, 0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(53, 22);
			this.button1.TabIndex = 4;
			this.button1.Text = "More";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// AC
			// 
			this.AC.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.AC.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.AC.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.AC.Location = new System.Drawing.Point(204, 4);
			this.AC.Name = "AC";
			this.AC.ReadOnly = true;
			this.AC.Size = new System.Drawing.Size(50, 13);
			this.AC.TabIndex = 3;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label8.Location = new System.Drawing.Point(178, 4);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(21, 13);
			this.label8.TabIndex = 2;
			this.label8.Text = "AC";
			// 
			// mobNumber
			// 
			this.mobNumber.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.mobNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.mobNumber.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.mobNumber.Location = new System.Drawing.Point(112, 4);
			this.mobNumber.Name = "mobNumber";
			this.mobNumber.Size = new System.Drawing.Size(51, 13);
			this.mobNumber.TabIndex = 1;
			this.mobNumber.TextChanged += new System.EventHandler(this.mobNumber_TextChanged);
			// 
			// mobType
			// 
			this.mobType.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.mobType.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.mobType.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.mobType.Location = new System.Drawing.Point(6, 4);
			this.mobType.Name = "mobType";
			this.mobType.Size = new System.Drawing.Size(100, 13);
			this.mobType.TabIndex = 0;
			this.mobType.TextChanged += new System.EventHandler(this.mobType_TextChanged);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 7;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.4127F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.5873F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 63F));
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.label5, 4, 0);
			this.tableLayoutPanel1.Controls.Add(this.label6, 5, 0);
			this.tableLayoutPanel1.Controls.Add(this.label7, 6, 0);
			this.tableLayoutPanel1.Controls.Add(this.Str, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.Dex, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.Int, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.Wis, 3, 1);
			this.tableLayoutPanel1.Controls.Add(this.Con, 4, 1);
			this.tableLayoutPanel1.Controls.Add(this.Cha, 5, 1);
			this.tableLayoutPanel1.Controls.Add(this.Hp, 6, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.77778F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.22222F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(397, 45);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(20, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Str";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label2.Location = new System.Drawing.Point(52, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(26, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Dex";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label3.Location = new System.Drawing.Point(105, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(19, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Int";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label4.Location = new System.Drawing.Point(165, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(25, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Wis";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label5.Location = new System.Drawing.Point(224, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(26, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Con";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label6.Location = new System.Drawing.Point(280, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(26, 13);
			this.label6.TabIndex = 5;
			this.label6.Text = "Cha";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label7.Location = new System.Drawing.Point(336, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(21, 13);
			this.label7.TabIndex = 6;
			this.label7.Text = "Hp";
			// 
			// Str
			// 
			this.Str.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.Str.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Str.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.Str.Location = new System.Drawing.Point(3, 20);
			this.Str.Name = "Str";
			this.Str.ReadOnly = true;
			this.Str.Size = new System.Drawing.Size(43, 13);
			this.Str.TabIndex = 7;
			// 
			// Dex
			// 
			this.Dex.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.Dex.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Dex.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.Dex.Location = new System.Drawing.Point(52, 20);
			this.Dex.Name = "Dex";
			this.Dex.ReadOnly = true;
			this.Dex.Size = new System.Drawing.Size(47, 13);
			this.Dex.TabIndex = 8;
			// 
			// Int
			// 
			this.Int.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.Int.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Int.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.Int.Location = new System.Drawing.Point(105, 20);
			this.Int.Name = "Int";
			this.Int.ReadOnly = true;
			this.Int.Size = new System.Drawing.Size(54, 13);
			this.Int.TabIndex = 9;
			// 
			// Wis
			// 
			this.Wis.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.Wis.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Wis.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.Wis.Location = new System.Drawing.Point(165, 20);
			this.Wis.Name = "Wis";
			this.Wis.ReadOnly = true;
			this.Wis.Size = new System.Drawing.Size(53, 13);
			this.Wis.TabIndex = 10;
			// 
			// Con
			// 
			this.Con.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.Con.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Con.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.Con.Location = new System.Drawing.Point(224, 20);
			this.Con.Name = "Con";
			this.Con.ReadOnly = true;
			this.Con.Size = new System.Drawing.Size(50, 13);
			this.Con.TabIndex = 11;
			// 
			// Cha
			// 
			this.Cha.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.Cha.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Cha.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.Cha.Location = new System.Drawing.Point(280, 20);
			this.Cha.Name = "Cha";
			this.Cha.ReadOnly = true;
			this.Cha.Size = new System.Drawing.Size(50, 13);
			this.Cha.TabIndex = 12;
			// 
			// Hp
			// 
			this.Hp.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.Hp.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Hp.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.Hp.Location = new System.Drawing.Point(336, 20);
			this.Hp.Name = "Hp";
			this.Hp.Size = new System.Drawing.Size(48, 13);
			this.Hp.TabIndex = 13;
			// 
			// MobEntry
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.Controls.Add(this.splitContainer1);
			this.DoubleBuffered = true;
			this.Name = "MobEntry";
			this.Size = new System.Drawing.Size(397, 74);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TextBox mobNumber;
		private System.Windows.Forms.TextBox mobType;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox Str;
		private System.Windows.Forms.TextBox Dex;
		private System.Windows.Forms.TextBox Int;
		private System.Windows.Forms.TextBox Wis;
		private System.Windows.Forms.TextBox Con;
		private System.Windows.Forms.TextBox Cha;
		private System.Windows.Forms.TextBox Hp;
		private System.Windows.Forms.TextBox AC;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button button1;
	}
}
