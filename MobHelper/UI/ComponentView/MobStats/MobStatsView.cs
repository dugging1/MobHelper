using MobHelper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobHelper.UI.ComponentView.MobStats {
	public class MobStatsView : IComponentView {
		public TabPage TP { get; private set; }
		private readonly Model.MobStats ms;
		public IComponent Component { get => ms; }

		public MobStatsView(Model.MobStats ms) {
			this.ms = ms;
			TP = new TabPage {
				BackColor = System.Drawing.Color.Black,
				Text = "Stats"
			};
			MobStatsControl msc = new MobStatsControl(ms) { Parent = TP };
		}
	}
}
