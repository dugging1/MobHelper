using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobHelper.Model;

namespace TaoMobs {
    class UnyeildingRoach : TaoMob {
		public UnyeildingRoach() : base() {
			IStats s = (IStats)getComponent(typeof(IStats));
			s.Strength = 4+MobRollHelper.roll(2, 4);
			s.Dexterity = 2+MobRollHelper.roll(1, 6);
			s.Intelligence = 4+MobRollHelper.roll(1, 4)/2;
			s.Wisdom = 4+MobRollHelper.roll(1, 4)/2;
			s.Constitution = 2+MobRollHelper.roll(2, 4);
			s.Charisma = MobRollHelper.roll(1, 4)-4;
			s.Speed = 30;
			s.AC = 20+Convert.ToInt32(Math.Floor((s.Dexterity-10.0)/2.0));
			s.HP = MobRollHelper.addHp(this, startHP, HPDice, NumHPDice);
		}

		public override string Name {
			get { return "Unyielding Roach"; }
		}

		protected int startHP { get { return 2; } }
        protected int HPDice { get { return 6; } }
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
 * Attack : 
 * Skin crawl
 * Bite
 * Scratch
 * 
 */
