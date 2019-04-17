using MobHelper.Mobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaoMobs {
	class MagmaWorm : TaoMob {
		protected override IMobStatBlock Stats {
			get {
				return new MobStats().New(
					new int[7] {	45+MobRollHelper.roll(2,4), 45+MobRollHelper.roll(2,4),
									20+MobRollHelper.roll(1,4), 20+MobRollHelper.roll(2,4),
									30+MobRollHelper.roll(4,4), 16+MobRollHelper.roll(1,4),
									0}, 
					"Magma Worm");
			}
		}

		protected override int startHP { get { return 130; } }

		protected override int HPDice { get { return 10; } }

		protected override int NumHPDice { get { return 4; } }

		public override int getAC(IMobStatBlock ms) {
			return 23+(ms.Stats[1]-10)/2;
		}
	}
}
