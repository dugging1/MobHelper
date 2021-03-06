﻿using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobHelper.Model;

namespace TaoMobs {
	class Cockatrice : TaoMob {
		public Cockatrice() : base() {
			Name = "Cockatrice";
			IStats s = (IStats)getComponent(typeof(IStats));
			s.Strength = 4+MobRollHelper.roll(1, 6);
			s.Dexterity = 8+MobRollHelper.roll(1, 6);
			s.Intelligence = MobRollHelper.roll(1, 4);
			s.Wisdom = 10+MobRollHelper.roll(1, 6);
			s.Constitution = 10+MobRollHelper.roll(1, 4);
			s.Charisma = 2+MobRollHelper.roll(1, 4);
			s.Speed = 30;
			s.AC = 10+Convert.ToInt32(Math.Floor((s.Dexterity-10.0)/2.0));
			s.HP = MobRollHelper.addHp(this, startHP, HPDice, 1);
		}
		public Cockatrice(string name, int num, ImmutableHashSet<IComponent> comps) : this() {
			Name = name;
			Number = num;
			Components = comps;
		}
		public override IMob New(string name, int number, ImmutableHashSet<IComponent> comps) => new Cockatrice(name, number, comps);

		protected int startHP {
			get => 22;
		}

		protected int HPDice {
			get => 10;
		}
	}
}
