using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobHelper.Mobs;

namespace MobHelper.Mobs {
	class RedJackel : TaoMob {
		protected override IMobStatBlock Stats { get {
				return new MobStats().New(new int[7] { 12+MobRollHelper.roll(2, 4), 8+MobRollHelper.roll(1, 6), 4+MobRollHelper.roll(1, 4)/2,
					4+MobRollHelper.roll(1, 4)/2, 8+MobRollHelper.roll(2, 4), MobRollHelper.roll(1, 4), 0 }, "Red Jackel");
			} }
		protected override int startHP { get { return 15; } }
		protected override int HPDice { get { return 6; } }

		public override int getAC(IMobStatBlock ms) {
			return 10+(ms.Stats[1]-10)/2;
		}
	}
}
