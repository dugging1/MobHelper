using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MobHelper.UI.ComponentView.Inventory;

namespace MobHelper.Model {
	public interface IItem {

		string Name { get; }
		string Description { get; }
		IItemViewFactory Generator { get; }

	}
}