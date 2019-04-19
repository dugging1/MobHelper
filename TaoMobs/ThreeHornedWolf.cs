using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobHelper.Mobs;

namespace MobHelper.Mobs {
	class ThreeHornedWolf : TaoMob {
		protected override IMobStatBlock Stats {
			get {
				return new MobStats().New(new int[7] {
					6+MobRollHelper.roll(2, 4),
					15+MobRollHelper.roll(2, 6),
					4+MobRollHelper.roll(1, 4),
					6+MobRollHelper.roll(2, 4),
					10+MobRollHelper.roll(1, 6),
					2+MobRollHelper.roll(1, 4),
					0 }, "Threehorned Wolf");
			}
		}

		protected override int startHP {
			get {
				return 45;
			}
		}

		protected override int HPDice {
			get {
				return 8;
			}
		}

		public override int getAC(IMobStatBlock ms) {
			return 10+(ms.Stats[1]-10)/2;
		}
	}
}
