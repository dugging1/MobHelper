using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobHelper.Model;

namespace TaoMobs {
	class Cockatrice : TaoMob {
		public Cockatrice() : base() {
			IStats s = (IStats)getComponent(typeof(IStats));
			s.Strength = 4+MobRollHelper.roll(1, 6);
			s.Dexterity = 8+MobRollHelper.roll(1, 6);
			s.Intelligence = MobRollHelper.roll(1, 4);
			s.Wisdom = 10+MobRollHelper.roll(1, 6);
			s.Constitution = 10+MobRollHelper.roll(1, 4);
			s.Charisma = 2+MobRollHelper.roll(1, 4);
			s.Speed = 30;
			s.AC = 10+(s.Dexterity-10)/2;
			s.HP = MobRollHelper.addHp(this, startHP, HPDice, 1);
		}

		public override string Name {
			get { return "Cockatrice"; }
		}

		protected int startHP {
			get { return 22; }
		}

		protected int HPDice {
			get { return 10; }
		}
	}
}
