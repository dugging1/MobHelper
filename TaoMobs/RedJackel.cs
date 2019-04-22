using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobHelper.Model;

namespace TaoMobs {
	class RedJackel : TaoMob {
		public RedJackel():base() {
			IStats s = (IStats)getComponent(typeof(IStats));
			s.Strength = 12+MobRollHelper.roll(2, 4);
			s.Dexterity = 8+MobRollHelper.roll(1, 6);
			s.Intelligence = 4+MobRollHelper.roll(1, 4)/2;
			s.Wisdom = 4+MobRollHelper.roll(1, 4)/2;
			s.Constitution = 8+MobRollHelper.roll(2, 4);
			s.Charisma = MobRollHelper.roll(1, 4);
			s.Speed = 30;
			s.AC = 10+(s.Dexterity-10)/2;
			s.HP = MobRollHelper.addHp(this, startHP, HPDice, 1);
		}

		public override string Name {
			get { return "RedJackel"; }
		}

		protected int startHP { get { return 15; } }
		protected int HPDice { get { return 6; } }
	}
}
