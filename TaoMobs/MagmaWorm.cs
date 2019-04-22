using MobHelper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaoMobs {
	class MagmaWorm : TaoMob {
		public MagmaWorm() : base() {
			IStats s = (IStats)getComponent(typeof(IStats));
			s.Strength = 45+MobRollHelper.roll(2, 4);
			s.Dexterity = 45+MobRollHelper.roll(2, 4);
			s.Intelligence = 20+MobRollHelper.roll(1, 4);
			s.Wisdom = 20+MobRollHelper.roll(2, 4);
			s.Constitution = 30+MobRollHelper.roll(4, 4);
			s.Charisma = 16+MobRollHelper.roll(1, 4);
			s.Speed = 40;
			s.AC = 23+Convert.ToInt32(Math.Floor((s.Dexterity-10.0)/2.0));
			s.HP = MobRollHelper.addHp(this, startHP, HPDice, NumHPDice);
		}

		public override string Name { get { return "Magma Worm"; } }

		protected int startHP { get { return 130; } }

		protected int HPDice { get { return 10; } }

		protected int NumHPDice { get { return 4; } }
	}
}
