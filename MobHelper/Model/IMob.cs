using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobHelper.Model {
	public interface IMob {

		string Name { get; }
		int Number { get; set; }
		HashSet<IComponent> Components { get; }

		IComponent getComponent(Type t);
	}
}