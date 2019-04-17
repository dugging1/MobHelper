using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobHelper.Mobs;

namespace MobHelper.Mobs {
	class BuriedWeasel : TaoMob {
		protected override IMobStatBlock Stats {
			get {
				return new MobStats().New(new int[7] { 8+MobRollHelper.roll(1, 6)/2, 4+MobRollHelper.roll(1, 6), 4+MobRollHelper.roll(1, 4)/2,
					4+MobRollHelper.roll(1, 4)/2, 8+MobRollHelper.roll(1, 4), MobRollHelper.roll(1, 4), 0 }, "Buried Weasel");
			}
		}

		protected override int startHP {
			get {
				return 8;
			}
		}

		protected override int HPDice {
			get {
				return 4;
			}
		}

		public override int getAC(IMobStatBlock ms) {
			return 12+(ms.Stats[1]-10)/2;
		}
	}
}
