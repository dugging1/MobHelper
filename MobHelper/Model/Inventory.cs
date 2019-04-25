
using MobHelper.UI.ComponentView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobHelper.Model {
	public class Inventory : IComponent {
		public HashSet<IItem> InventorySet = new HashSet<IItem>();

		public string Name { get => "Inventory"; }

		public string Description { get => "A creature's inventory."; }

		protected componentViewFactory gen = new componentViewFactory();
		public componentViewFactory Generator { get => gen; }

		public IComponentView visit(componentViewFactory gen) => gen.generate(this);
	}
}