using MobHelper.UI.ComponentView.HarvestTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobHelper.Model {
	public class HarvestEntry {

		public HarvestEntry() { }

		public IItem Item;
		public int DC;
		public Dictionary<string, IRollAction> ResultRolls;
		public HarvestEntryControlFactory Factory;

	}
}