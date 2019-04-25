using MobHelper.Model;
using MobHelper.UI.ComponentView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobHelper.UI.ComponentView.Inventory {
	class InventoryView : IComponentView {
		public TabPage TP { get; private set; }
		protected readonly Model.Inventory inv;
		public IComponent Component { get => inv; }

		public InventoryView(Model.Inventory I) {
			inv = I;
			TP = new TabPage {
				BackColor = System.Drawing.Color.Black,
				Text = "Inventory"
			};
			InventoryControl inventoryView = new InventoryControl(inv) { Parent = TP, Dock = DockStyle.Fill };
		}
	}
}
