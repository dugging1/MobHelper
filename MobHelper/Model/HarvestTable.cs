
using MobHelper.UI.ComponentView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobHelper.Model {
	public class HarvestTable : IComponent {

		public HarvestTable() { }

		public HashSet<HarvestEntry> Harvests { get; }

		public string Name { get; }
		public string Description { get; }

		protected componentViewFactory gen = new componentViewFactory();
		public componentViewFactory Generator { get => gen; }

		public IComponentView visit(componentViewFactory gen) => gen.generate(this);
	}
}