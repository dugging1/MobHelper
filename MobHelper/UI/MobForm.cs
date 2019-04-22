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
		private IMob Mob { get; set; }

		public MobForm(IMob mob) {
			InitializeComponent();
			Mob = mob;
		}
	}
}
