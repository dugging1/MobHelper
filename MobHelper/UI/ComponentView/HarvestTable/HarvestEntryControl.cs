using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobHelper.UI.ComponentView.HarvestTable {
	public partial class HarvestEntryControl : UserControl {
		protected Model.HarvestEntry HE { get; set; }

		public HarvestEntryControl(Model.HarvestEntry he) {
			InitializeComponent();
			HE = he;
			ItemNameBox.Text = HE.Item.Name;
			DC.Text = HE.DC.ToString();
			for (int i = 0; i < HE.ResultRolls.Count; i++) {
				if (i != 0)
					RollResultTable.RowCount += 1;
				Label l = new Label() { Text=HE.ResultRolls.ToList()[i].Key, Parent=RollResultTable };
				RollResultTable.SetRow(l, i);
				RollResultTable.SetColumn(l, 0);
				Button btn = new Button() { Text="Roll", Parent=RollResultTable };
				btn.Click += new EventHandler((x, y) => MessageBox.Show("Roll result: "+HE.ResultRolls.ToList()[RollResultTable.GetRow((Control)x)].Value.roll().ToString()));
				RollResultTable.SetRow(btn, i);
				RollResultTable.SetColumn(btn, 1);
			}
		}
	}
}
