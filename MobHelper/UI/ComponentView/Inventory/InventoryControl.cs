using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobHelper.UI.ComponentView.Inventory {
	public partial class InventoryControl : UserControl {
		public InventoryControl(Model.Inventory I) {
			InitializeComponent();
			IEnumerable<UserControl> items = I.InventorySet.Select(x => x.Generator.generate(x));
			items.Select(x => x.Anchor = AnchorStyles.Left);
			items.Select(x => x.Parent = ItemPanel);
		}
	}
}
