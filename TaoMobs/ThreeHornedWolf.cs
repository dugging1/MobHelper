using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobHelper.Model;

namespace TaoMobs {
	class ThreeHornedWolf : TaoMob {
		public ThreeHornedWolf() : base() {
			IStats s = (IStats)getComponent(typeof(IStats));
			s.Strength = 6+MobRollHelper.roll(2, 4);
			s.Dexterity = 15+MobRollHelper.roll(2, 6);
			s.Intelligence = 4+MobRollHelper.roll(1, 4);
			s.Wisdom = 6+MobRollHelper.roll(2, 4);
			s.Constitution = 10+MobRollHelper.roll(1, 6);
			s.Charisma = 2+MobRollHelper.roll(1, 4);
			s.Speed = 40;
			s.AC = 10+Convert.ToInt32(Math.Floor((s.Dexterity-10.0)/2.0));
			s.HP = MobRollHelper.addHp(this, startHP, HPDice, 1);
		}

		public override string Name { get { return "Three-Horned Wolf"; } }

		protected int startHP { get { return 45; } }

		protected int HPDice { get { return 8; } }
	}
}
