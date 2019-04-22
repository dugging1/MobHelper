
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobHelper.Model {
	public abstract class TaoMob : IMob {

		public TaoMob() {
			Components = new HashSet<IComponent>();
			Components.Add(new MobStats());
		}

		public float OAPoints { get { return MobRollHelper.calcOAPoints(this); } }

		public abstract string Name { get; }
		public virtual int Number { get; set; }
		public virtual HashSet<IComponent> Components { get; protected set; }

		public IComponent getComponent(Type t) {
			foreach (IComponent component in Components) {
				if (t.IsInstanceOfType(component))
					return component;
			}
			throw new KeyNotFoundException("Component not found.");
		}
	}
}