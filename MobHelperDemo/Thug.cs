using MobHelper;
using MobHelper.Model;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobHelperDemo {
	class Thug : IMob {
		public Thug() {
			Components = ImmutableHashSet.Create<IComponent>(new MobStats());
			IStats s = (IStats)getComponent(typeof(IStats));
			s.Strength = 15;
			s.Dexterity = 11;
			s.Intelligence = 10;
			s.Wisdom = 10;
			s.Constitution = 14;
			s.Charisma = 11;
			s.Speed = 30;
			s.HP = MobRollHelper.roll(5, 8)+10;
			s.AC = 11;
		}

		public Thug(string name, int num, ImmutableHashSet<IComponent> comps) {
			this.name = name;
			Number = num;
			Components = comps;
		}

		protected string name = "Thug";
		public string Name { get => name; protected set { name = value; } }

		public int Number { get; set; }

		public ImmutableHashSet<IComponent> Components { get; private set; }

		public IComponent getComponent(Type t) {
			foreach (IComponent c in Components) {
				if (t.IsInstanceOfType(c))
					return c;
			}
			throw new KeyNotFoundException("Component not found.");
		}

		public IMob New(string name, int number, ImmutableHashSet<IComponent> comps) => new Thug(name, number, comps);
	}
}
