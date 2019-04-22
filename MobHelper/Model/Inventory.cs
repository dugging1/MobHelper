
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobHelper.Model {
	public class Inventory : IComponent {
		public HashSet<IItem> InventorySet = new HashSet<IItem>();

		public string Name { get { return "Inventory"; } }

		public string Description { get; }

		public IComponentView visit(componentViewGenerator gen) {
			return gen.generate(this);
		}
	}
}