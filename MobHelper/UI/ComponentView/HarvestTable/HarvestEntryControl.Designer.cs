namespace MobHelper.UI.ComponentView.HarvestTable {
	partial class HarvestEntryControl {
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
			this.label1 = new System.Windows.Forms.Label();
			this.ItemNameBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.DC = new System.Windows.Forms.TextBox();
			this.RollResultTable = new System.Windows.Forms.TableLayoutPanel();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.BackColor = System.Drawing.Color.Black;
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.DC);
			this.splitContainer1.Panel1.Controls.Add(this.label2);
			this.splitContainer1.Panel1.Controls.Add(this.ItemNameBox);
			this.splitContainer1.Panel1.Controls.Add(this.label1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.RollResultTable);
			this.splitContainer1.Size = new System.Drawing.Size(753, 125);
			this.splitContainer1.SplitterDistance = 48;
			this.splitContainer1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label1.Location = new System.Drawing.Point(3, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(27, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Item";
			// 
			// ItemNameBox
			// 
			this.ItemNameBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ItemNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ItemNameBox.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.ItemNameBox.Location = new System.Drawing.Point(36, 20);
			this.ItemNameBox.Name = "ItemNameBox";
			this.ItemNameBox.ReadOnly = true;
			this.ItemNameBox.Size = new System.Drawing.Size(248, 13);
			this.ItemNameBox.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label2.Location = new System.Drawing.Point(315, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(22, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "DC";
			// 
			// DC
			// 
			this.DC.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.DC.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.DC.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.DC.Location = new System.Drawing.Point(343, 20);
			this.DC.Name = "DC";
			this.DC.ReadOnly = true;
			this.DC.Size = new System.Drawing.Size(100, 13);
			this.DC.TabIndex = 3;
			// 
			// RollResultTable
			// 
			this.RollResultTable.AutoSize = true;
			this.RollResultTable.ColumnCount = 2;
			this.RollResultTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.RollResultTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.RollResultTable.Dock = System.Windows.Forms.DockStyle.Fill;
			this.RollResultTable.Location = new System.Drawing.Point(0, 0);
			this.RollResultTable.Name = "RollResultTable";
			this.RollResultTable.RowCount = 1;
			this.RollResultTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.RollResultTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.RollResultTable.Size = new System.Drawing.Size(753, 73);
			this.RollResultTable.TabIndex = 0;
			// 
			// HarvestEntryControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.Controls.Add(this.splitContainer1);
			this.Name = "HarvestEntryControl";
			this.Size = new System.Drawing.Size(753, 125);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TextBox ItemNameBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox DC;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TableLayoutPanel RollResultTable;
	}
}
