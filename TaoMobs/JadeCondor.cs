using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobHelper.Mobs;

namespace MobHelper.Mobs {
	class JadeCondor : TaoMob {
		protected override IMobStatBlock Stats {
			get {
				return new MobStats().New(new int[7] {
					8+MobRollHelper.roll(2,4),
					15+MobRollHelper.roll(2,8),
					4+MobRollHelper.roll(1,4),
					8+MobRollHelper.roll(1,4),
					10+MobRollHelper.roll(1,6),
					6+MobRollHelper.roll(1,4),
					0 }, "Jade Condor");
			}
		}

		protected override int startHP { get { return 30; } }

		protected override int HPDice { get { return 6; } }

		public override int getAC(IMobStatBlock ms) {
			return 11+(ms.Stats[1]-10)/2;
		}
	}
}

/*
 * Encounters: [1+(1d4)/2]
 * 
 * Attacks:
 * Swoop: Adds extra damage to other attacks.
 * Claw: [2d8+dex.] ([+3d4] after swoop).
 * 
 */
