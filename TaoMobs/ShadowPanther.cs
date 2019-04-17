using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobHelper.Mobs;

namespace MobHelper.Mobs {
	class ShadowPanther : TaoMob {
		protected override IMobStatBlock Stats {
			get {
				return new MobStats().New(new int[7] {
					12+MobRollHelper.roll(3, 4), 15+MobRollHelper.roll(2, 6),
					2+MobRollHelper.roll(1, 8), 8+MobRollHelper.roll(2, 4),
					14+MobRollHelper.roll(1, 4), 4+MobRollHelper.roll(1, 6), 0 }, "Shadow Panther");
			}
		}

		protected override int startHP {
			get {
				return 50;
			}
		}

		protected override int HPDice {
			get {
				return 20;
			}
		}

		public override int getAC(IMobStatBlock ms) {
			return 11+(ms.Stats[1]-10)/2;
		}
	}
}
