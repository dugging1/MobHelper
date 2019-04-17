using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobHelper.Mobs;

namespace MobHelper.Mobs {
	class NightmareCrow:TaoMob {
		protected override IMobStatBlock Stats { get {
				return new MobStats().New(new int[7] {
					10+MobRollHelper.roll(1, 4)/2, 10+MobRollHelper.roll(2, 4),
					4+MobRollHelper.roll(1, 4)/2, 4+MobRollHelper.roll(1, 4)/2,
					6+MobRollHelper.roll(1, 4), 1+MobRollHelper.roll(1, 4), 0 }, "Nightmare Crow");
			} }
		protected override int startHP { get { return 10; } }
		protected override int HPDice { get { return 6; } }

		public override int getAC(IMobStatBlock ms) {
			return 12+(ms.Stats[1]-10)/2;
		}
	}
}
