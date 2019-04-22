using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobHelper.Model;

namespace TaoMobs {
	class BuriedWeasel : TaoMob {
		public BuriedWeasel():base() {
			IStats s = (IStats)getComponent(typeof(IStats));
			s.Strength = 8+MobRollHelper.roll(1, 6)/2;
			s.Dexterity = 4+MobRollHelper.roll(1, 6);
			s.Intelligence = 4+MobRollHelper.roll(1, 4)/2;
			s.Wisdom = 4+MobRollHelper.roll(1, 4)/2;
			s.Constitution = 8+MobRollHelper.roll(1, 4);
			s.Charisma = MobRollHelper.roll(1, 4);
			s.Speed = 30;
			s.AC = 12+Convert.ToInt32(Math.Floor((s.Dexterity-10.0)/2.0));
			s.HP = MobRollHelper.addHp(this, startHP, HPDice, 1);
		}

		public override string Name {
			get { return "Buried Weasel"; }
		}

		protected int startHP {
			get { return 8; }
		}

		protected int HPDice {
			get { return 4; }
		}
	}
}
