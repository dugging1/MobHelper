using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobHelper.Model;

namespace TaoMobs {
	class JadeCondor : TaoMob {
		public JadeCondor() : base() {
			Name = "Jade Condor";
			IStats s = (IStats)getComponent(typeof(IStats));
			s.Strength = 8+MobRollHelper.roll(2, 4);
			s.Dexterity = 15+MobRollHelper.roll(2, 8);
			s.Intelligence = 4+MobRollHelper.roll(1, 4);
			s.Wisdom = 8+MobRollHelper.roll(1, 4);
			s.Constitution = 10+MobRollHelper.roll(1, 6);
			s.Charisma = 6+MobRollHelper.roll(1, 4);
			s.Speed = 40;
			s.AC = 11+Convert.ToInt32(Math.Floor((s.Dexterity-10.0)/2.0));
			s.HP = MobRollHelper.addHp(this, startHP, HPDice, 1);
		}
		public JadeCondor(string name, int num, ImmutableHashSet<IComponent> comps) : this() {
			Name = name;
			Number = num;
			Components = comps;
		}
		public override IMob New(string name, int number, ImmutableHashSet<IComponent> comps) => new JadeCondor(name, number, comps);

		protected int startHP { get { return 30; } }

		protected int HPDice { get { return 6; } }
	}
}

/*
 * Encounters: [1+(1d4)/2]
 * 
 * Attacks:
 * Swoop: Adds extra damage to other attacks.
 * Claw: [2d8+dex.] ([+3d4] after swoop).
 * 
 */
