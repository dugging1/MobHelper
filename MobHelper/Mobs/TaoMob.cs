using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobHelper.Mobs;

namespace MobHelper.Mobs {
	public abstract class TaoMob : Mob {
		protected abstract IMobStatBlock Stats { get; }
		protected abstract int startHP { get; }
		protected abstract int HPDice { get; }
		protected virtual int NumHPDice { get { return 1; } }

		protected virtual  IMobStatBlock changeStatNumber(int n, IMobStatBlock stats) {
			IMobStatBlock s = stats;
			s.Number = n;
			return s;
		}

		public virtual IMobStatBlock getMobStats(int number) {
			IMobStatBlock ms = changeStatNumber(number+1, MobRollHelper.addHp(Stats, startHP, HPDice, NumHPDice));
			int[] stats = new int[ms.Stats.Length+1];
			for (int i = 0; i<ms.Stats.Length; i++)
				stats[i] = ms.Stats[i];
			stats[7] = getAC(ms);
			ms.Stats = stats;
			return ms;
		}

		public abstract int getAC(IMobStatBlock ms);
	}
}
