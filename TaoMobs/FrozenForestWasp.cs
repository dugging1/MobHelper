using MobHelper.Mobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaoMobs {
	class FrozenForestWasp : TaoMob {
		protected override IMobStatBlock Stats {
			get { return new MobStats().New(new int[7] {
				12+MobRollHelper.roll(1,6), 18+MobRollHelper.roll(2,4),
				10+MobRollHelper.roll(1,4), 12+MobRollHelper.roll(1,8),
				12+MobRollHelper.roll(1,8), MobRollHelper.roll(1,4), 0
			}, "Frozen Forest Wasp"); }
		}

		protected override int startHP {
			get { return 30; }
		}

		protected override int HPDice {
			get { return 8; }
		}

		public override int getAC(IMobStatBlock ms) {
			return 11+(ms.Stats[1]-10)/2;
		}
	}
}
