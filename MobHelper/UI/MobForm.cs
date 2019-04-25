using MobHelper.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobHelper.UI {
	public partial class MobForm : Form {
		protected IMob Mob { get; set; }

		public MobForm(IMob mob) {
			InitializeComponent();
			Mob = mob;
			ComponentTabs.TabPages.AddRange(Mob.Components.Select(x => x.Generator.generate(x)).Select(x => x.TP).ToArray());
			Text = "Mob - "+Mob.Name+" ("+Mob.Number+")";
		}
	}
}
