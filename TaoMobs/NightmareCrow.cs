﻿using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobHelper.Model;

namespace TaoMobs {
	class NightmareCrow:TaoMob {
		public NightmareCrow() : base() {
			Name = "Nightmare Crow";
			IStats s = (IStats)getComponent(typeof(IStats));
			s.Strength = 10+MobRollHelper.roll(1, 4)/2;
			s.Dexterity = 10+MobRollHelper.roll(2, 4);
			s.Intelligence = 4+MobRollHelper.roll(1, 4)/2;
			s.Wisdom = 4+MobRollHelper.roll(1, 4)/2;
			s.Constitution = 6+MobRollHelper.roll(1, 4);
			s.Charisma = 1+MobRollHelper.roll(1, 4);
			s.Speed = 30;
			s.AC = 12+Convert.ToInt32(Math.Floor((s.Dexterity-10.0)/2.0));
			s.HP = MobRollHelper.addHp(this, startHP, HPDice, 1);
		}

		public NightmareCrow(string name, int num, ImmutableHashSet<IComponent> comps) : this() {
			Name = name;
			Number = num;
			Components = comps;
		}
		public override IMob New(string name, int number, ImmutableHashSet<IComponent> comps) => new NightmareCrow(name, number, comps);

		protected int startHP { get { return 10; } }
		protected int HPDice { get { return 6; } }
	}
}
