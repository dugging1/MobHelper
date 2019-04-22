using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobHelper.Model;

namespace TaoMobs {
    class BlackJackel : TaoMob {
		public BlackJackel():base() {
			IStats s = (IStats)getComponent(typeof(IStats));
			s.Strength = 16+MobRollHelper.roll(2, 4);
			s.Dexterity = 11+MobRollHelper.roll(1, 6);
			s.Intelligence = 6+MobRollHelper.roll(1, 4)/2;
			s.Wisdom = 6+MobRollHelper.roll(1, 4)/2;
			s.Constitution = 10+MobRollHelper.roll(2, 4);
			s.Charisma = MobRollHelper.roll(1, 4);
			s.Speed = 30;
			s.AC = 13+Convert.ToInt32(Math.Floor((s.Dexterity-10.0)/2.0));
			s.HP = MobRollHelper.addHp(this, startHP, HPDice, 1);
		}

		public override string Name {
			get { return "Black Jackel"; }
		}

		protected int startHP { get { return 30; } }
        protected int HPDice { get { return 6; } }
    }
}

/* 
 * Encounters: [1+1d4]
 * 
 * Attacks:
 * Bite: [1d8+Str.]
 * Claw: [1d6+Dex.]
 * 
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
