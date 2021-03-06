﻿using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobHelper.Model;

namespace TaoMobs {
    class WingedBear : TaoMob {
		public WingedBear() : base() {
			Name = "Winged Bear";
			IStats s = (IStats)getComponent(typeof(IStats));
			s.Strength = 16+MobRollHelper.roll(2, 3);
			s.Dexterity = 8+MobRollHelper.roll(2, 4);
			s.Intelligence = 4+MobRollHelper.roll(1, 4)/2;
			s.Wisdom = 4+MobRollHelper.roll(1, 4)/2;
			s.Constitution = 8+MobRollHelper.roll(1, 4);
			s.Charisma = MobRollHelper.roll(1, 6);
			s.Speed = 30;
			s.AC = 15+Convert.ToInt32(Math.Floor((s.Dexterity-10.0)/2.0));
			s.HP = MobRollHelper.addHp(this, startHP, HPDice, NumHPDice);
		}
		public WingedBear(string name, int num, ImmutableHashSet<IComponent> comps) : this() {
			Name = name;
			Number = num;
			Components = comps;
		}
		public override IMob New(string name, int number, ImmutableHashSet<IComponent> comps) => new WingedBear(name, number, comps);

		protected int startHP { get { return 30; } }
        protected int HPDice { get { return 10; } }
        protected int NumHPDice { get { return 4; } }
    }
}

/* trbp.
 * Stats: STR DEX INT WIS CON CHR 0
 * 
 * startHP: static amount of innit hp. 
 * HPDice : Size of dice.
 * NumHPDice : Number of dice.
 * 
 * Attack :
 * Charged Swipe
 * Chain Swipe
 * Empowered Jaw
 * 
 */
