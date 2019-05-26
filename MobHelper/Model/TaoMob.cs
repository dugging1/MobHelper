
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;

namespace MobHelper.Model {
	public abstract class TaoMob : IMob {

		public TaoMob() {
			Components = ImmutableHashSet.Create<IComponent>(new MobStats());
		}

		public float OAPoints { get { return MobRollHelper.calcOAPoints(this); } }

		public virtual string Name { get; protected set; }
		public virtual int Number { get; set; }
		public virtual ImmutableHashSet<IComponent> Components { get; protected set; }

		public IComponent getComponent(Type t) {
			foreach (IComponent component in Components) {
				if (t.IsInstanceOfType(component))
					return component;
			}
			throw new KeyNotFoundException("Component not found.");
		}

		public abstract IMob New(string name, int number, ImmutableHashSet<IComponent> comps);
	}
}