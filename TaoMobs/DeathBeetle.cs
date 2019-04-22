using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobHelper.Model;

namespace TaoMobs {
    class DeathBeetle : TaoMob {
		public DeathBeetle():base() {
			IStats s = (IStats)getComponent(typeof(IStats));
			s.Strength = 2+MobRollHelper.roll(4, 5);
			s.Dexterity = 4+MobRollHelper.roll(1, 6);
			s.Intelligence = 15;
			s.Wisdom = 15;
			s.Constitution = 8+MobRollHelper.roll(2, 4);
			s.Charisma = MobRollHelper.roll(1, 4)-5;
			s.Speed = 30;
			s.AC = 10+Convert.ToInt32(Math.Floor((s.Dexterity-10.0)/2.0));
			s.HP = MobRollHelper.addHp(this, startHP, HPDice, NumHPDice);
		}

		public override string Name {
			get { return "Death beetle"; }
		}

		protected int startHP { get { return 2; } }
        protected int HPDice { get { return 2; } }
        protected int NumHPDice { get { return MobRollHelper.roll(1, 6); } }
    }
}

/*
 * Encounters: [6+2d4]
 * 
 * Attacks:
 * Bite: [1d4+Str.]
 * /

/* trbp.
 * Stats: STR DEX INT WIS CON CHR 0
 * 
 * startHP: static amount of innit hp. 
 * HPDice : Size of dice.
 * NumHPDice : Number of dice.
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 */
