using System;
using System.Collections.Immutable;
using System.Linq;
using System.Text;

namespace MobHelper.Model {
	public interface IMob {
		IMob New(string name, int number, ImmutableHashSet<IComponent> comps);
		string Name { get; }
		int Number { get; set; }
		ImmutableHashSet<IComponent> Components { get; }

		IComponent getComponent(Type t);
	}

	public static class IMobExtensions {
		public static IMob changeName(this IMob m, string name) => m.New(name, m.Number, m.Components);
		public static IMob changeNumber(this IMob m, int number) => m.New(m.Name, number, m.Components);
		public static IMob changeComponants(this IMob m, ImmutableHashSet<IComponent> comps) => m.New(m.Name, m.Number, comps);
		public static IMob addComponant(this IMob m, IComponent c) => m.New(m.Name, m.Number, m.Components.Add(c));
	}
}