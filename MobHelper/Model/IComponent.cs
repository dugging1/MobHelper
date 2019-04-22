
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobHelper.Model {
	public interface IComponent {

		string Name { get; }
		string Description { get; }

		IComponentView visit(componentViewGenerator gen);
	}
}