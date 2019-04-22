using MobHelper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaoMobs {
	class DreamBlueButterfly : TaoMob {
		public DreamBlueButterfly() : base() {
			IStats s = (IStats)getComponent(typeof(IStats));
			s.Strength = 12+MobRollHelper.roll(1, 4);
			s.Dexterity = 18+MobRollHelper.roll(2, 4);
			s.Intelligence = 16+MobRollHelper.roll(2, 4);
			s.Wisdom = 16+MobRollHelper.roll(2, 4);
			s.Constitution = 16+MobRollHelper.roll(1, 4);
			s.Charisma = 16+MobRollHelper.roll(1, 4);
			s.Speed = 40;
			s.AC = 12+(s.Dexterity-10)/2;
			s.HP = MobRollHelper.addHp(this, startHP, HPDice, 1);
		}

		public override string Name {
			get { return "Dream Blue Butterfly"; }
		}

		protected int startHP {
			get { return 12; }
		}

		protected int HPDice {
			get { return 8; }
		}
	}
}

/*
 * Encounters: [1]
 * 
 * Attacks: 
 * Illusion (A): Int. roll off with target. On a success, can change target's perception of env.
 * Damaging Illusion (A): Can deal [3d6+Int]  to a target that is under the influence of 'Illusion'.
 */
