using System;
using System.Windows.Forms;
using MobHelper.Mobs;

namespace MobHelper.UI {
	public partial class InitiativeEntry : UserControl, IComparable {
		public delegate void removeDelegate(InitiativeEntry i);
		private removeDelegate remDel;

		public InitiativeEntry(MobStats ms, removeDelegate rem) {
			InitializeComponent();
			EntryName.Text = ms.Name + " " + ms.Number.ToString();
			int initiative = MobRollHelper.roll(1, 20)+Convert.ToInt32(Math.Floor((ms.Stats[1]-10.0)/2.0));
			EntryInitiative.Text = initiative.ToString();
			remDel = rem;
		}

		public InitiativeEntry(string name, int init, removeDelegate rem) {
			InitializeComponent();
			EntryName.Text = name;
			EntryInitiative.Text = init.ToString();
			remDel = rem;
		}

		public int CompareTo(object obj) {
			return Convert.ToInt32(EntryInitiative.Text).CompareTo(Convert.ToInt32((obj as InitiativeEntry).EntryInitiative.Text));
		}

		private void InitiativeEntry_Load(object sender, EventArgs e) {

		}

		private void removeEntry_Click(object sender, EventArgs e) {
			remDel(this);
		}
	}
}
