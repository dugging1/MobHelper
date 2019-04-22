using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobHelper.Model {
	public static class MobRollHelper {
		public static Dictionary<string, int> typeNumHighest = new Dictionary<string, int>();
		private static Random rand = new Random();
		public static IEnumerable<Type> mobs;

		public static int roll(int num, int dice) {
			int tot = 0;
			for (int i = 0; i < num; i++) {
				tot += rand.Next(1, dice+1);
			}
			return tot;
		}

		public static float calcOAPoints(IMob ms) {
			IStats stats = (IStats)ms.getComponent(typeof(IStats));
			float tot = stats.Strength+stats.Dexterity+stats.Intelligence+stats.Wisdom;
			return (float)(tot/20.0);
		}

		public static int addHp(IMob ms, int startHp, int dice, int numDice) {
			IStats stats = (IStats)ms.getComponent(typeof(IStats));
			int OA = Convert.ToInt32(Math.Floor(calcOAPoints(ms)));
			int conMod = Convert.ToInt32(Math.Floor((stats.Constitution-10.0)/20.0));
			return startHp+(OA+1)*conMod+roll(OA*numDice, dice);
		}

		public static IMob getMob(Type mob) {
			if (!mobs.Contains(mob))
				throw new KeyNotFoundException("Mob type does not implement the Mob interface.");
			IMob m = ((IMob)Activator.CreateInstance(mob));
			int n;
			bool b = typeNumHighest.TryGetValue(m.Name, out n);
			if (!b) n=0;
			else typeNumHighest.Remove(m.Name);
			typeNumHighest.Add(m.Name, n+1);
			m.Number = n;
			return m;
		}

		public static IMob getMob(string name) {
			IEnumerable<Type> ts = mobs.Where(t => ((IMob)Activator.CreateInstance(t)).Name.Equals(name));
			if (ts.Count() == 0)
				throw new KeyNotFoundException("Mob name not found in list of mob types.");
			return getMob(ts.First());
		}
	}
}
