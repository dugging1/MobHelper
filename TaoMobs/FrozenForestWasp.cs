using MobHelper.Model;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaoMobs {
	class FrozenForestWasp : TaoMob {
		public FrozenForestWasp() : base() {
			Name = "Frozen Forest Wasp";
			IStats s = (IStats)getComponent(typeof(IStats));
			s.Strength = 12+MobRollHelper.roll(1, 6);
			s.Dexterity = 18+MobRollHelper.roll(2, 4);
			s.Intelligence = 10+MobRollHelper.roll(1, 4);
			s.Wisdom = 12+MobRollHelper.roll(1, 8);
			s.Constitution = 12+MobRollHelper.roll(1, 8);
			s.Charisma = MobRollHelper.roll(1, 4);
			s.Speed = 40;
			s.AC = 12+Convert.ToInt32(Math.Floor((s.Dexterity-10.0)/2.0));
			s.HP = MobRollHelper.addHp(this, startHP, HPDice, 1);
		}
		public FrozenForestWasp(string name, int num, ImmutableHashSet<IComponent> comps) : this() {
			Name = name;
			Number = num;
			Components = comps;
		}
		public override IMob New(string name, int number, ImmutableHashSet<IComponent> comps) => new FrozenForestWasp(name, number, comps);

		protected int startHP {
			get { return 30; }
		}

		protected int HPDice {
			get { return 8; }
		}
	}
}


/*
 * Encounters: [2+1d4]
 * 
 * Attacks:
 * Stinger strike: [2d6+str.]
 * Cold poison: Target rolls a DC 16 Con. saving throw. On a fail, the target takes [2d4] damage per turn for [1d4] rounds.
 */