using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobHelper.Model;

namespace TaoMobs {
	class AshWorm : TaoMob {
		public AshWorm():base() {
			IStats s = (IStats)getComponent(typeof(IStats));
			s.Strength = 45+MobRollHelper.roll(2, 10);
			s.Dexterity = 45+MobRollHelper.roll(2, 6);
			s.Intelligence = 25+MobRollHelper.roll(1, 4);
			s.Wisdom = 20+MobRollHelper.roll(1, 4);
			s.Constitution = 30+MobRollHelper.roll(2, 4);
			s.Charisma = 16+MobRollHelper.roll(1, 4);
			s.Speed = 40;
			s.AC = 23+(s.Dexterity-10)/2;
			s.HP = MobRollHelper.addHp(this, startHP, HPDice, NumHPDice);
		}

		public override string Name { get { return "Magma Worm"; } }

		protected int startHP { get { return 150; } }
		protected int HPDice { get { return 10; } }
        protected int NumHPDice { get { return 5; } }
	}
}

/*
 * Stats: STR DEX INT WIS CON CHR 0
 * 
 * startHP: static amount of innit hp. 
 * HPDice : Size of dice.
 * NumHPDice : Number of dice.
 * 
 * 
 * 1/2 chance for the magma worm to die and form into an ash worm
 * 
 * Attacks : 
 * Blinding Ash
 * Terrofying Slam
 * Ground Rend
 * Death Rattle
 * 
 */