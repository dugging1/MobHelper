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
				12+MobRollHelper.roll(1,6),
				18+MobRollHelper.roll(2,4),
				10+MobRollHelper.roll(1,4),
				12+MobRollHelper.roll(1,8),
				12+MobRollHelper.roll(1,8),
				MobRollHelper.roll(1,4), 0
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


/*
 * Encounters: [2+1d4]
 * 
 * Attacks:
 * Stinger strike: [2d6+str.]
 * Cold poison: Target rolls a DC 16 Con. saving throw. On a fail, the target takes [2d4] damage per turn for [1d4] rounds.
 */