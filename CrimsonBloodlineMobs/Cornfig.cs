using MobHelper.Model;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LanguageExt;
using static LanguageExt.Prelude;

namespace CrimsonBloodlineMobs {
	class Cornfig : IMob {

		public Cornfig() {
			Components = ImmutableHashSet.Create<IComponent>(new MobStats());
			IStats s = (IStats)getComponent(typeof(IStats));
			s.Strength = 10;
			s.Dexterity = 10;
			s.Intelligence = 10;
			s.Wisdom = 10;
			s.Constitution = 10;
			s.Charisma = 10;
			s.Speed = 30;
			s.HP = MobRollHelper.roll(5, 8) + 10;
			s.AC = 11;
		}
		public Cornfig(string name, int number, ImmutableHashSet<IComponent> comps) {
			Name = name;
			Number = number;
			Components = comps;
		}

		private string name = "Cornfig";
		public string Name { get => name; set { name = value; } }

		public int Number { get; set; }

		public ImmutableHashSet<IComponent> Components { get; private set; }

		public IComponent getComponent(Type t) => Components.Filter(x => t.IsInstanceOfType(x)).HeadOrNone().Match(x => x, () => throw new ArgumentException("Component not found."));

		public IMob New(string name, int number, ImmutableHashSet<IComponent> comps) => new Cornfig(name, number, comps);
	}
}
