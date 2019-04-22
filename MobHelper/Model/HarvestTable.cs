
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

		public IComponentView visit(componentViewGenerator gen) => gen.generate(this);
	}
}