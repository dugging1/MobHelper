using MobHelper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobHelper.UI.ComponentView.MobStats {
	public class MobStatsView : IComponentView {
		public MobStatsView(Model.MobStats ms) {
			this.ms = ms;
			TP = new TabPage();
			MobStatsControl msc = new MobStatsControl(ms);
			msc.Parent = TP;
			msc.Dock = DockStyle.Fill;
		}

		public TabPage TP { get; private set; }

		private Model.MobStats ms;
		public IComponent Component { get { return ms; } }
	}
}
