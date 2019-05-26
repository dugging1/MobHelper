using MobHelper.Model;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaoMobs {
	class DreamBlueButterfly : TaoMob {
		public DreamBlueButterfly() : base() {
			Name = "Dream Blue Butterfly";
			IStats s = (IStats)getComponent(typeof(IStats));
			s.Strength = 12+MobRollHelper.roll(1, 4);
			s.Dexterity = 18+MobRollHelper.roll(2, 4);
			s.Intelligence = 16+MobRollHelper.roll(2, 4);
			s.Wisdom = 16+MobRollHelper.roll(2, 4);
			s.Constitution = 16+MobRollHelper.roll(1, 4);
			s.Charisma = 16+MobRollHelper.roll(1, 4);
			s.Speed = 40;
			s.AC = 12+Convert.ToInt32(Math.Floor((s.Dexterity-10.0)/2.0));
			s.HP = MobRollHelper.addHp(this, startHP, HPDice, 1);
		}
		public DreamBlueButterfly(string name, int num, ImmutableHashSet<IComponent> comps) : this() {
			Name = name;
			Number = num;
			Components = comps;
		}
		public override IMob New(string name, int number, ImmutableHashSet<IComponent> comps) => new DreamBlueButterfly(name, number, comps);

		protected int startHP {
			get => 12;
		}

		protected int HPDice {
			get => 8;
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
