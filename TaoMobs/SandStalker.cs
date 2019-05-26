using MobHelper.Model;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaoMobs {
	public class SandStalker : TaoMob {
		protected int startHP { get => 75; }
		protected int HPDice { get => 8; }

		public SandStalker():base() {
			Name = "Sand Stalker";
			IStats s = (IStats)getComponent(typeof(IStats));
			s.Strength = 12+MobRollHelper.roll(4, 6);
			s.Dexterity = 15+MobRollHelper.roll(3, 8);
			s.Intelligence = 4+MobRollHelper.roll(1, 4);
			s.Wisdom = 10+MobRollHelper.roll(3, 4);
			s.Constitution = 14+MobRollHelper.roll(5, 4);
			s.Charisma = MobRollHelper.roll(3, 4);
			s.Speed = 30;
			s.AC = 12+Convert.ToInt32(Math.Floor((s.Dexterity-10.0)/2.0));
			s.HP = MobRollHelper.addHp(this, startHP, HPDice, 2);
		}

		public SandStalker(string name, int num, ImmutableHashSet<IComponent> comps) : this() {
			Name = name;
			Number = num;
			Components = comps;
		}
		public override IMob New(string name, int number, ImmutableHashSet<IComponent> comps) => new SandStalker(name, number, comps);
	}
}

/*
 * Encounters: [1]
 * 
 * Attacks: 
 *	-Hidden in the sand(BA): Beast Str. roll Vs Perception. On success next atk. has adv.
 *	-Claw Strike(A): [10+4d6+Str.] ([+2d4] if hidden)
 *	-Sandstorm(Talent) (A): 15ft Diameter circle makes a Con. saving throw. On success take half dmg. Otherwise take [6d8] dmg.
 *	
 *	Harvest Table:
 *	Meat: DC 15; Succ => 1 Meat; Crit Succ => 1 HQ Meat
 *	Claw: DC 16; Fail => 1 Claw; Succ => 2 Claw; Crit Succ => 4 Claw
 *	
 */