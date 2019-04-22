namespace MobHelper.UI {
	partial class MobForm {
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
			this.ComponentTabs = new System.Windows.Forms.CustomTabControl();
			this.SuspendLayout();
			// 
			// ComponentTabs
			// 
			// 
			// 
			// 
			this.ComponentTabs.DisplayStyleProvider.BorderColor = System.Drawing.SystemColors.ControlDark;
			this.ComponentTabs.DisplayStyleProvider.BorderColorHot = System.Drawing.SystemColors.ControlDark;
			this.ComponentTabs.DisplayStyleProvider.BorderColorSelected = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
			this.ComponentTabs.DisplayStyleProvider.CloserColor = System.Drawing.Color.DarkGray;
			this.ComponentTabs.DisplayStyleProvider.FocusTrack = true;
			this.ComponentTabs.DisplayStyleProvider.HotTrack = true;
			this.ComponentTabs.DisplayStyleProvider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ComponentTabs.DisplayStyleProvider.Opacity = 1F;
			this.ComponentTabs.DisplayStyleProvider.Overlap = 0;
			this.ComponentTabs.DisplayStyleProvider.Padding = new System.Drawing.Point(6, 3);
			this.ComponentTabs.DisplayStyleProvider.Radius = 2;
			this.ComponentTabs.DisplayStyleProvider.ShowTabCloser = false;
			this.ComponentTabs.DisplayStyleProvider.TextColor = System.Drawing.SystemColors.ControlText;
			this.ComponentTabs.DisplayStyleProvider.TextColorDisabled = System.Drawing.SystemColors.ControlDark;
			this.ComponentTabs.DisplayStyleProvider.TextColorSelected = System.Drawing.SystemColors.ControlText;
			this.ComponentTabs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ComponentTabs.HotTrack = true;
			this.ComponentTabs.Location = new System.Drawing.Point(0, 0);
			this.ComponentTabs.Name = "ComponentTabs";
			this.ComponentTabs.SelectedIndex = 0;
			this.ComponentTabs.Size = new System.Drawing.Size(800, 450);
			this.ComponentTabs.TabIndex = 0;
			// 
			// MobForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.ComponentTabs);
			this.Name = "MobForm";
			this.Text = "Mob";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.CustomTabControl ComponentTabs;
	}
}