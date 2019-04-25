using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MobHelper.Model;

namespace MobHelper.UI.ComponentView.HarvestTable {
	class HarvestTableView : IComponentView {
		public TabPage TP { get; private set; }
		protected readonly Model.HarvestTable HT;
		public IComponent Component { get => HT; }

		public HarvestTableView(Model.HarvestTable ht) {
			HT = ht;
			TP = new TabPage {
				BackColor = System.Drawing.Color.Black,
				Text = "Harvest Tables"
			};
			HarvestTableControl msc = new HarvestTableControl(ht) { Parent = TP };
		}
	}
}
