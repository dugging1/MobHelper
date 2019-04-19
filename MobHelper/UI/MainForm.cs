using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MobHelper.Mobs;
using TaoHelper.UI;

namespace MobHelper.UI {
	public partial class MainForm : Form {
		List<IMobStatBlock> rolledMobs = new List<IMobStatBlock>();
		List<IMobDisplayBlock> mobPanels = new List<IMobDisplayBlock>();
		List<InitiativeEntry> initiatives = new List<InitiativeEntry>();
		InitiativePanel InitTrackPanel = new InitiativePanel();

		public Color MobBtnBackColour { get; set; }
		public Color MobBtnTextColour { get; set; }

		public Color StatBackColour { get; set; }
		public Color StatForeColour { get; set; }

		public Color InitiativeBackColour { get; set; }
		public Color InitiativeForeColour { get; set; }

		MobRollerBtnPanel MobBtnPanel = new MobRollerBtnPanel();

		public MainForm() {
			InitializeComponent();
			InitTrackPanel.Parent = InitTrackSPanel.Panel1;
			InitTrackPanel.Dock = DockStyle.Fill;
			InitTrackPanel.AutoScroll = true;

			MobBtnPanel.Parent = MobRollerSplitBtnsTB.Panel2;
			MobBtnPanel.Dock = DockStyle.Fill;

			MobBtnBackColour = SystemColors.ControlDarkDark;
			MobBtnTextColour = SystemColors.ControlLight;
			StatBackColour = Color.FromArgb(64, 64, 64);
			StatForeColour = SystemColors.ControlLight;
			InitiativeBackColour = Color.Black;
			InitiativeForeColour = SystemColors.ControlLight;
		}

		private void Form1_Load(object sender, EventArgs e) {
			MobRollHelper.mobs = AppDomain.CurrentDomain.GetAssemblies().SelectMany(s => s.GetTypes()).Where(p => typeof(Mob).IsAssignableFrom(p) && p.IsClass && !p.IsAbstract);
			foreach (Type type in MobRollHelper.mobs) {
				createMobBtn(((Mob)Activator.CreateInstance(type)).getMobStats(0).Name);
			}
			MobBtnPanel.Invalidate();
		}

		private void createMobBtn(string name) {
			Button btn = new Button();
			btn.Click += MobCreationBtnCallback;
			btn.Text = name;
			
			btn.Anchor = (AnchorStyles)(AnchorStyles.Right|AnchorStyles.Left|AnchorStyles.Top);
			btn.AutoSize = true;
			btn.AutoSizeMode = AutoSizeMode.GrowOnly;
			btn.Size = ClearMobs.Size;

			btn.FlatStyle = FlatStyle.Flat;
			btn.FlatAppearance.BorderSize = 0;
			btn.BackColor = MobBtnBackColour;
			btn.ForeColor = MobBtnTextColour;

			MobBtnPanel.Controls.Add(btn);
			btn.Show();
		}

		#region InitiativeTab

		private void clearInit_Click(object sender, EventArgs e) {
			InitTrackPanel.Hide();
			foreach (InitiativeEntry initiativeEntry in initiatives) {
				initiativeEntry.Dispose();
			}
			initiatives = new List<InitiativeEntry>();
			InitTrackPanel.AutoScrollPosition = new Point(0, 0);
			InitTrackPanel.AutoScrollMargin = new Size(0, 0);
			InitTrackPanel.Show();
		}

		private void addMobs_Click(object sender, EventArgs e) {
			InitTrackPanel.Hide();
			foreach (MobStats ms in rolledMobs) {
				InitiativeEntry i = new InitiativeEntry(ms, removeInitiativeEntry);
				i.ForeColor = InitiativeForeColour;
				i.BackColor = InitiativeBackColour;
				initiatives.Add(i);
				i.Parent = InitTrackPanel;
			}
			InitTrackPanel.PerformLayout();
			InitTrackPanel.Show();
		}

		private void removeInitiativeEntry(InitiativeEntry i) {
			initiatives.Remove(i);
			i.Dispose();
		}

		private void addEntry_Click(object sender, EventArgs e) {
			InitiativeEntry i = new InitiativeEntry(InitName.Text, Convert.ToInt32(InitVal.Text), removeInitiativeEntry);
			initiatives.Add(i);
			i.Parent = InitTrackPanel;
		}

		#endregion

		private void ClearMobs_Click(object sender, EventArgs e) {
			MobPanelDock.Hide();
			foreach (Control c in mobPanels) {
				c.Dispose();
			}

			MobRollHelper.typeNumHighest = new Dictionary<string, int>();
			rolledMobs = new List<IMobStatBlock>();
			mobPanels = new List<IMobDisplayBlock>();
			MobPanelDock.Show();
		}

		private void MobCreationBtnCallback(object sender, EventArgs e) {
			try {
				Button b = (Button)sender;
				IMobStatBlock ms = MobRollHelper.getMob(b.Text);
				rolledMobs.Add(ms);
				IMobDisplayBlock me = new MobEntry(ms) { BackColor = StatBackColour, ForeColor = StatForeColour, Parent = MobPanelDock };
				mobPanels.Add(me);
			} finally { }
		}

		private void Form1_ResizeBegin(object sender, EventArgs e) {
			MobPanelDock.Hide();
			InitTrackPanel.Hide();
		}

		private void Form1_ResizeEnd(object sender, EventArgs e) {
			MobPanelDock.Show();
			InitTrackPanel.Show();
		}

		private void customTabControl1_Selecting(object sender, TabControlCancelEventArgs e) {
			foreach (Control item in Tabs.TabPages) {
				item.Hide();
			}
		}

		private void customTabControl1_TabIndexChanged(object sender, EventArgs e) {
			foreach (Control item in Tabs.TabPages) {
				item.Show();
			}
		}
	}
}
