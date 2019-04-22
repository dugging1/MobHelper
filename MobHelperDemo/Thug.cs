using MobHelper;
using MobHelper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobHelperDemo {
	class Thug : IMob {
		public Thug() {
			//Int[9] => {Str, Dex, Int, Wis, Con, Cha, Speed, Hp, AC}
			MobStats s = new MobStats(new int[9] { 15, 11, 10, 10, 14, 11, 30, MobRollHelper.roll(5, 8)+10, 11 });
		}

		public string Name { get { return "Thug"; } }

		public int Number { get; set; }

		public HashSet<IComponent> Components { get; }

		public IComponent getComponent(Type t) {
			foreach (IComponent c in Components) {
				if (t.GetType().IsAssignableFrom(c.GetType()))
					return c;
			}
			throw new KeyNotFoundException("Component not found.");
		}

	}
}
