using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobHelper.Mobs;

namespace MobHelper.Mobs {
	class Cockatrice : TaoMob {
		protected override IMobStatBlock Stats {
			get {
				return new MobStats().New(new int[7] { 4+MobRollHelper.roll(1, 6), 8+MobRollHelper.roll(1, 6), MobRollHelper.roll(1, 4), 10+MobRollHelper.roll(1, 6),
					10+MobRollHelper.roll(1, 4), 2+MobRollHelper.roll(1, 4), 0 }, "Cockatrice");
			}
		}

		protected override int startHP {
			get {
				return 22;
			}
		}

		protected override int HPDice {
			get {
				return 10;
			}
		}

		public override int getAC(IMobStatBlock ms) {
			return 10+(ms.Stats[1]-10)/2;
		}
	}
}
