using MobHelper;
using MobHelper.Mobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobHelperDemo {
	class Thug : Mob {
		public int getAC(IMobStatBlock ms) {
			return 11;
		}

		//Int[8] => {Str, Dex, Int, Wis, Con, Cha, Hp, AC}
		public IMobStatBlock getMobStats(int number) {
			return new MobStats().New(new int[8] { 15, 11, 10, 10, 14, 11, MobRollHelper.roll(5, 8)+10, 11 }, "Thug", number);
		}
	}
}
