namespace MobHelper.UI {
	partial class InitiativeEntry {
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
			this.EntryName = new System.Windows.Forms.TextBox();
			this.EntryInitiative = new System.Windows.Forms.TextBox();
			this.removeEntry = new System.Windows.Forms.Button();
			this.EntryNumber = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// EntryName
			// 
			this.EntryName.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.EntryName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.EntryName.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.EntryName.Location = new System.Drawing.Point(4, 9);
			this.EntryName.Name = "EntryName";
			this.EntryName.ReadOnly = true;
			this.EntryName.Size = new System.Drawing.Size(169, 13);
			this.EntryName.TabIndex = 0;
			// 
			// EntryInitiative
			// 
			this.EntryInitiative.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.EntryInitiative.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.EntryInitiative.ForeColor = System.Drawing.Color.White;
			this.EntryInitiative.Location = new System.Drawing.Point(316, 9);
			this.EntryInitiative.Name = "EntryInitiative";
			this.EntryInitiative.ReadOnly = true;
			this.EntryInitiative.Size = new System.Drawing.Size(20, 13);
			this.EntryInitiative.TabIndex = 1;
			// 
			// removeEntry
			// 
			this.removeEntry.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.removeEntry.FlatAppearance.BorderSize = 0;
			this.removeEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.removeEntry.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.removeEntry.Location = new System.Drawing.Point(342, 3);
			this.removeEntry.Name = "removeEntry";
			this.removeEntry.Size = new System.Drawing.Size(34, 24);
			this.removeEntry.TabIndex = 2;
			this.removeEntry.Text = "X";
			this.removeEntry.UseVisualStyleBackColor = false;
			this.removeEntry.Click += new System.EventHandler(this.removeEntry_Click);
			// 
			// EntryNumber
			// 
			this.EntryNumber.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.EntryNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.EntryNumber.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.EntryNumber.Location = new System.Drawing.Point(229, 9);
			this.EntryNumber.Name = "EntryNumber";
			this.EntryNumber.ReadOnly = true;
			this.EntryNumber.Size = new System.Drawing.Size(21, 13);
			this.EntryNumber.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(179, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Number";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(264, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Initiative";
			// 
			// InitiativeEntry
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.EntryNumber);
			this.Controls.Add(this.removeEntry);
			this.Controls.Add(this.EntryInitiative);
			this.Controls.Add(this.EntryName);
			this.Name = "InitiativeEntry";
			this.Size = new System.Drawing.Size(383, 30);
			this.Load += new System.EventHandler(this.InitiativeEntry_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox EntryName;
		private System.Windows.Forms.TextBox EntryInitiative;
		private System.Windows.Forms.Button removeEntry;
		private System.Windows.Forms.TextBox EntryNumber;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}
