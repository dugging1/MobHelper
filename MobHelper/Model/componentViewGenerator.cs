using MobHelper.UI.ComponentView.MobStats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobHelper.Model {
	public class componentViewGenerator {

		public componentViewGenerator() { }

		public IComponentView generate(IComponent comp) => comp.visit(this);
		

		public IComponentView generate(Inventory comp) {
			// TODO implement here
			return null;
		}

		public IComponentView generate(HarvestTable comp) {
			// TODO implement here
			return null;
		}

		public IComponentView generate(MobStats comp) {
			return new MobStatsView(comp);
		}

	}
}