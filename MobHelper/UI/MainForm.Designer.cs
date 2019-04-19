namespace MobHelper.UI {
	partial class MainForm {
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.ClearMobs = new System.Windows.Forms.Button();
			this.InitVal = new System.Windows.Forms.NumericUpDown();
			this.addMobs = new System.Windows.Forms.Button();
			this.clearInit = new System.Windows.Forms.Button();
			this.addEntry = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.InitName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.Tabs = new System.Windows.Forms.CustomTabControl();
			this.InitTrack = new System.Windows.Forms.TabPage();
			this.InitTrackSPanel = new System.Windows.Forms.SplitContainer();
			this.MobTrack = new System.Windows.Forms.TabPage();
			this.MobRollerSplitLR = new System.Windows.Forms.SplitContainer();
			this.MobPanelDock = new System.Windows.Forms.FlowLayoutPanel();
			this.MobRollerSplitBtnsTB = new System.Windows.Forms.SplitContainer();
			((System.ComponentModel.ISupportInitialize)(this.InitVal)).BeginInit();
			this.Tabs.SuspendLayout();
			this.InitTrack.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.InitTrackSPanel)).BeginInit();
			this.InitTrackSPanel.Panel2.SuspendLayout();
			this.InitTrackSPanel.SuspendLayout();
			this.MobTrack.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.MobRollerSplitLR)).BeginInit();
			this.MobRollerSplitLR.Panel1.SuspendLayout();
			this.MobRollerSplitLR.Panel2.SuspendLayout();
			this.MobRollerSplitLR.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.MobRollerSplitBtnsTB)).BeginInit();
			this.MobRollerSplitBtnsTB.Panel1.SuspendLayout();
			this.MobRollerSplitBtnsTB.SuspendLayout();
			this.SuspendLayout();
			// 
			// ClearMobs
			// 
			this.ClearMobs.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClearMobs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ClearMobs.FlatAppearance.BorderSize = 0;
			this.ClearMobs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ClearMobs.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.ClearMobs.Location = new System.Drawing.Point(0, 0);
			this.ClearMobs.Name = "ClearMobs";
			this.ClearMobs.Size = new System.Drawing.Size(191, 33);
			this.ClearMobs.TabIndex = 1;
			this.ClearMobs.Text = "Clear Mobs";
			this.ClearMobs.UseVisualStyleBackColor = false;
			this.ClearMobs.Click += new System.EventHandler(this.ClearMobs_Click);
			// 
			// InitVal
			// 
			this.InitVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.InitVal.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.InitVal.Location = new System.Drawing.Point(66, 81);
			this.InitVal.Name = "InitVal";
			this.InitVal.Size = new System.Drawing.Size(275, 16);
			this.InitVal.TabIndex = 7;
			// 
			// addMobs
			// 
			this.addMobs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.addMobs.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.addMobs.FlatAppearance.BorderSize = 0;
			this.addMobs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addMobs.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.addMobs.Location = new System.Drawing.Point(66, 136);
			this.addMobs.Name = "addMobs";
			this.addMobs.Size = new System.Drawing.Size(83, 23);
			this.addMobs.TabIndex = 6;
			this.addMobs.Text = "Add Mobs";
			this.addMobs.UseVisualStyleBackColor = false;
			this.addMobs.Click += new System.EventHandler(this.addMobs_Click);
			// 
			// clearInit
			// 
			this.clearInit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.clearInit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.clearInit.FlatAppearance.BorderSize = 0;
			this.clearInit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.clearInit.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.clearInit.Location = new System.Drawing.Point(66, 165);
			this.clearInit.Name = "clearInit";
			this.clearInit.Size = new System.Drawing.Size(83, 23);
			this.clearInit.TabIndex = 5;
			this.clearInit.Text = "Clear Initiative";
			this.clearInit.UseVisualStyleBackColor = false;
			this.clearInit.Click += new System.EventHandler(this.clearInit_Click);
			// 
			// addEntry
			// 
			this.addEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.addEntry.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.addEntry.FlatAppearance.BorderSize = 0;
			this.addEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addEntry.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.addEntry.Location = new System.Drawing.Point(66, 107);
			this.addEntry.Name = "addEntry";
			this.addEntry.Size = new System.Drawing.Size(83, 23);
			this.addEntry.TabIndex = 4;
			this.addEntry.Text = "Add Entry";
			this.addEntry.UseVisualStyleBackColor = false;
			this.addEntry.Click += new System.EventHandler(this.addEntry_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Initiative";
			// 
			// InitName
			// 
			this.InitName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.InitName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.InitName.Location = new System.Drawing.Point(66, 54);
			this.InitName.Name = "InitName";
			this.InitName.Size = new System.Drawing.Size(275, 13);
			this.InitName.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(24, 54);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name";
			// 
			// Tabs
			// 
			this.Tabs.Controls.Add(this.InitTrack);
			this.Tabs.Controls.Add(this.MobTrack);
			// 
			// 
			// 
			this.Tabs.DisplayStyleProvider.BorderColor = System.Drawing.Color.Black;
			this.Tabs.DisplayStyleProvider.BorderColorHot = System.Drawing.Color.Black;
			this.Tabs.DisplayStyleProvider.BorderColorSelected = System.Drawing.Color.Black;
			this.Tabs.DisplayStyleProvider.CloserColor = System.Drawing.Color.Black;
			this.Tabs.DisplayStyleProvider.FocusColor = System.Drawing.Color.Black;
			this.Tabs.DisplayStyleProvider.FocusTrack = true;
			this.Tabs.DisplayStyleProvider.HotTrack = true;
			this.Tabs.DisplayStyleProvider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Tabs.DisplayStyleProvider.Opacity = 1F;
			this.Tabs.DisplayStyleProvider.Overlap = 0;
			this.Tabs.DisplayStyleProvider.Padding = new System.Drawing.Point(6, 3);
			this.Tabs.DisplayStyleProvider.Radius = 2;
			this.Tabs.DisplayStyleProvider.ShowTabCloser = false;
			this.Tabs.DisplayStyleProvider.TextColor = System.Drawing.Color.Black;
			this.Tabs.DisplayStyleProvider.TextColorDisabled = System.Drawing.SystemColors.ControlText;
			this.Tabs.DisplayStyleProvider.TextColorSelected = System.Drawing.SystemColors.ControlText;
			this.Tabs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Tabs.HotTrack = true;
			this.Tabs.Location = new System.Drawing.Point(0, 0);
			this.Tabs.Name = "Tabs";
			this.Tabs.SelectedIndex = 0;
			this.Tabs.Size = new System.Drawing.Size(979, 583);
			this.Tabs.TabIndex = 1;
			this.Tabs.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.customTabControl1_Selecting);
			this.Tabs.TabIndexChanged += new System.EventHandler(this.customTabControl1_TabIndexChanged);
			// 
			// InitTrack
			// 
			this.InitTrack.BackColor = System.Drawing.Color.Black;
			this.InitTrack.Controls.Add(this.InitTrackSPanel);
			this.InitTrack.Location = new System.Drawing.Point(4, 23);
			this.InitTrack.Name = "InitTrack";
			this.InitTrack.Padding = new System.Windows.Forms.Padding(3);
			this.InitTrack.Size = new System.Drawing.Size(971, 556);
			this.InitTrack.TabIndex = 0;
			this.InitTrack.Text = "Initiative Track";
			// 
			// InitTrackSPanel
			// 
			this.InitTrackSPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.InitTrackSPanel.Location = new System.Drawing.Point(3, 3);
			this.InitTrackSPanel.Name = "InitTrackSPanel";
			// 
			// InitTrackSPanel.Panel1
			// 
			this.InitTrackSPanel.Panel1.AutoScroll = true;
			this.InitTrackSPanel.Panel1.BackColor = System.Drawing.Color.Black;
			// 
			// InitTrackSPanel.Panel2
			// 
			this.InitTrackSPanel.Panel2.BackColor = System.Drawing.Color.Black;
			this.InitTrackSPanel.Panel2.Controls.Add(this.InitVal);
			this.InitTrackSPanel.Panel2.Controls.Add(this.InitName);
			this.InitTrackSPanel.Panel2.Controls.Add(this.label2);
			this.InitTrackSPanel.Panel2.Controls.Add(this.clearInit);
			this.InitTrackSPanel.Panel2.Controls.Add(this.addMobs);
			this.InitTrackSPanel.Panel2.Controls.Add(this.addEntry);
			this.InitTrackSPanel.Panel2.Controls.Add(this.label1);
			this.InitTrackSPanel.Size = new System.Drawing.Size(965, 550);
			this.InitTrackSPanel.SplitterDistance = 604;
			this.InitTrackSPanel.TabIndex = 0;
			// 
			// MobTrack
			// 
			this.MobTrack.BackColor = System.Drawing.Color.Black;
			this.MobTrack.Controls.Add(this.MobRollerSplitLR);
			this.MobTrack.Location = new System.Drawing.Point(4, 23);
			this.MobTrack.Name = "MobTrack";
			this.MobTrack.Padding = new System.Windows.Forms.Padding(3);
			this.MobTrack.Size = new System.Drawing.Size(971, 556);
			this.MobTrack.TabIndex = 1;
			this.MobTrack.Text = "Mob Roller";
			// 
			// MobRollerSplitLR
			// 
			this.MobRollerSplitLR.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MobRollerSplitLR.Location = new System.Drawing.Point(3, 3);
			this.MobRollerSplitLR.Name = "MobRollerSplitLR";
			// 
			// MobRollerSplitLR.Panel1
			// 
			this.MobRollerSplitLR.Panel1.Controls.Add(this.MobPanelDock);
			// 
			// MobRollerSplitLR.Panel2
			// 
			this.MobRollerSplitLR.Panel2.Controls.Add(this.MobRollerSplitBtnsTB);
			this.MobRollerSplitLR.Size = new System.Drawing.Size(965, 550);
			this.MobRollerSplitLR.SplitterDistance = 770;
			this.MobRollerSplitLR.TabIndex = 0;
			// 
			// MobPanelDock
			// 
			this.MobPanelDock.AutoScroll = true;
			this.MobPanelDock.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MobPanelDock.Location = new System.Drawing.Point(0, 0);
			this.MobPanelDock.Name = "MobPanelDock";
			this.MobPanelDock.Size = new System.Drawing.Size(770, 550);
			this.MobPanelDock.TabIndex = 1;
			// 
			// MobRollerSplitBtnsTB
			// 
			this.MobRollerSplitBtnsTB.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MobRollerSplitBtnsTB.Location = new System.Drawing.Point(0, 0);
			this.MobRollerSplitBtnsTB.Name = "MobRollerSplitBtnsTB";
			this.MobRollerSplitBtnsTB.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// MobRollerSplitBtnsTB.Panel1
			// 
			this.MobRollerSplitBtnsTB.Panel1.Controls.Add(this.ClearMobs);
			this.MobRollerSplitBtnsTB.Size = new System.Drawing.Size(191, 550);
			this.MobRollerSplitBtnsTB.SplitterDistance = 33;
			this.MobRollerSplitBtnsTB.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Desktop;
			this.ClientSize = new System.Drawing.Size(979, 583);
			this.Controls.Add(this.Tabs);
			this.DoubleBuffered = true;
			this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainForm";
			this.Text = "Tao Helper";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResizeBegin += new System.EventHandler(this.Form1_ResizeBegin);
			this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
			((System.ComponentModel.ISupportInitialize)(this.InitVal)).EndInit();
			this.Tabs.ResumeLayout(false);
			this.InitTrack.ResumeLayout(false);
			this.InitTrackSPanel.Panel2.ResumeLayout(false);
			this.InitTrackSPanel.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.InitTrackSPanel)).EndInit();
			this.InitTrackSPanel.ResumeLayout(false);
			this.MobTrack.ResumeLayout(false);
			this.MobRollerSplitLR.Panel1.ResumeLayout(false);
			this.MobRollerSplitLR.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.MobRollerSplitLR)).EndInit();
			this.MobRollerSplitLR.ResumeLayout(false);
			this.MobRollerSplitBtnsTB.Panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.MobRollerSplitBtnsTB)).EndInit();
			this.MobRollerSplitBtnsTB.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.NumericUpDown InitVal;
		private System.Windows.Forms.Button addMobs;
		private System.Windows.Forms.Button clearInit;
		private System.Windows.Forms.Button addEntry;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox InitName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button ClearMobs;
		private System.Windows.Forms.CustomTabControl Tabs;
		private System.Windows.Forms.TabPage InitTrack;
		private System.Windows.Forms.TabPage MobTrack;
		private System.Windows.Forms.SplitContainer InitTrackSPanel;
		private System.Windows.Forms.SplitContainer MobRollerSplitLR;
		private System.Windows.Forms.FlowLayoutPanel MobPanelDock;
		private System.Windows.Forms.SplitContainer MobRollerSplitBtnsTB;
	}
}

