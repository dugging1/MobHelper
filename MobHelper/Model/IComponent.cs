
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MobHelper.UI.ComponentView;

namespace MobHelper.Model {
	public interface IComponent {

		string Name { get; }
		string Description { get; }
		componentViewFactory Generator { get; }

		IComponentView visit(componentViewFactory gen);
	}
}