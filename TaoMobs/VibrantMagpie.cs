using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobHelper.Model;

namespace TaoMobs {
    class VibrantMagpie : TaoMob {
		public VibrantMagpie() : base() {
			IStats s = (IStats)getComponent(typeof(IStats));
			s.Strength = 10+MobRollHelper.roll(2, 4);
			s.Dexterity = 10+MobRollHelper.roll(2, 6);
			s.Intelligence = 4+MobRollHelper.roll(1, 4)/2;
			s.Wisdom = 2+MobRollHelper.roll(1, 4)/2;
			s.Constitution = 6+MobRollHelper.roll(2, 4);
			s.Charisma = MobRollHelper.roll(1, 6);
			s.Speed = 40;
			s.AC = 14+Convert.ToInt32(Math.Floor((s.Dexterity-10.0)/2.0));
			s.HP = MobRollHelper.addHp(this, startHP, HPDice, NumHPDice);
		}

		public override string Name { get { return "Vibrant Magpie"; } }

		protected int startHP { get { return 15; } }
        protected int HPDice { get { return 5; } }
        protected int NumHPDice { get { return 2; } }
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
 * Blinding Light
 * Vibrant Claw
 * Shining Dive
 */
