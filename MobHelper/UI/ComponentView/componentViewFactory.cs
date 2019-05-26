using MobHelper.Model;
using MobHelper.UI.ComponentView.HarvestTable;
using MobHelper.UI.ComponentView.Inventory;
using MobHelper.UI.ComponentView.MobStats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobHelper.UI.ComponentView {
	public class componentViewFactory {
		public virtual IComponentView generate(IComponent comp) => comp.visit(this);

		public virtual IComponentView generate(Model.Inventory comp) => new InventoryView(comp);

		public virtual IComponentView generate(Model.HarvestTable comp) => new HarvestTableView(comp);

		public virtual IComponentView generate(Model.MobStats comp) =>  new MobStatsView(comp);

	}
}