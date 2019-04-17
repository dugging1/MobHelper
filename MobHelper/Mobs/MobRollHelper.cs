using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobHelper.Mobs;

namespace MobHelper.Mobs {
	public class MobStats:IMobStatBlock {
		public int[] Stats { get; set; } // = new int[8]; // => {Str, Dex, Int, Wis, Con, Cha}
		public string Name { get; set; }
		public int Number { get; set; }

		public IMobStatBlock New(int[] stats, string name ,int number=0) {
			Stats = stats;
			Name = name;
			Number = number;
			return this;
		}
	}

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

		public static int calcOAPoints(IMobStatBlock ms) {
			int tot = 0;
			for (int i = 0; i < 6; i++) {
				tot += ms.Stats[i];
			}
			return Convert.ToInt32(Math.Floor((double)tot/20.0));
		}

		public static IMobStatBlock addHp(IMobStatBlock ms, int startHp, int dice, int numDice) {
			int OA = calcOAPoints(ms);
			int conMod = Convert.ToInt32(Math.Floor((ms.Stats[4]-10.0)/20.0));
			ms.Stats[6] = startHp+(OA+1)*conMod+roll(OA*numDice, dice);
			return ms;
		}

		public static IMobStatBlock getMob(Type mob) {
			if (!mobs.Contains(mob))
				throw new KeyNotFoundException("Mob type does not implement the Mob interface.");
			IMobStatBlock m = ((Mob)Activator.CreateInstance(mob)).getMobStats(0);
			int n;
			bool b = typeNumHighest.TryGetValue(m.Name, out n);
			if (!b) n=0;
			if (b) typeNumHighest.Remove(m.Name);
			typeNumHighest.Add(m.Name, n+1);
			return ((Mob)Activator.CreateInstance(mob)).getMobStats(n);
		}

		public static IMobStatBlock getMob(string name) {
			IEnumerable<Type> ts = mobs.Where(t => ((Mob)Activator.CreateInstance(t)).getMobStats(0).Name.Equals(name));
			if (ts.Count() == 0)
				throw new KeyNotFoundException("Mob name not found in list of mob types.");
			return getMob(ts.First());
		}
	}
}
