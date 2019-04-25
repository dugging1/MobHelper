using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobHelper.UI.ComponentView.HarvestTable {
	public class HarvestEntryControlFactory {
		public HarvestEntryControl generate(Model.HarvestEntry he) => new HarvestEntryControl(he);
	}
}
