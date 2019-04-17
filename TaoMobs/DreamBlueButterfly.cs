using MobHelper.Mobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaoMobs {
	class DreamBlueButterfly : TaoMob {
		protected override IMobStatBlock Stats {
			get {
				return new MobStats().New(new int[7] { 12+MobRollHelper.roll(1,4), 18+MobRollHelper.roll(2,4),
														16+MobRollHelper.roll(2,4), 16+MobRollHelper.roll(2,4),
														16+MobRollHelper.roll(1,4), 16+MobRollHelper.roll(1,4), 0}, "Dream Blue Butterfly");
			}
		}

		protected override int startHP {
			get { return 12; }
		}

		protected override int HPDice {
			get { return 8; }
		}

		public override int getAC(IMobStatBlock ms) {
			return 12+(ms.Stats[1]-10)/2;
		}
	}
}
