﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobHelper.Model;

namespace TaoMobs {
    class ToweringTortoise : TaoMob {
		public ToweringTortoise() : base() {
			IStats s = (IStats)getComponent(typeof(IStats));
			s.Strength = 40+MobRollHelper.roll(5, 5);
			s.Dexterity = 10;
			s.Intelligence = 35+MobRollHelper.roll(2, 8)/2;
			s.Wisdom = 20+MobRollHelper.roll(2, 4)/2;
			s.Constitution = 8+MobRollHelper.roll(4, 4);
			s.Charisma = MobRollHelper.roll(8, 4);
			s.Speed = 20;
			s.AC = 40+(s.Dexterity-10)/2;
			s.HP = MobRollHelper.addHp(this, startHP, HPDice, NumHPDice);
		}

		public override string Name {
			get { return "Towering Tortoise"; }
		}

		protected int startHP { get { return 50; } }
        protected int HPDice { get { return 5; } }
        protected int NumHPDice { get { return 10; } }
    }
}

/* trbp.
 * Stats: STR DEX INT WIS CON CHR 0
 * 
 * startHP: static amount of innit hp. 
 * HPDice : Size of dice.
 * NumHPDice : Number of dice.
 * 
 * 
 * Attacks : 
 * Spin
 * Snap
 */
