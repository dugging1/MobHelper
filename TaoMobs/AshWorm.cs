using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobHelper.Mobs;

namespace MobHelper.Mobs {
	class AshWorm : TaoMob {
		protected override IMobStatBlock Stats { get {
				return new MobStats().New(new int[7] {
                    45+MobRollHelper.roll(2, 10),
                    45+MobRollHelper.roll(2, 6),
                    25+MobRollHelper.roll(1, 4),
					20+MobRollHelper.roll(1, 4),
                    30+MobRollHelper.roll(2, 4),
                    16+MobRollHelper.roll(1, 4), 0 }, "Ash Worm");
			} }
		protected override int startHP { get { return 150; } }
		protected override int HPDice { get { return 10; } }
        protected override int NumHPDice { get { return 5; } }

        public override int getAC(IMobStatBlock ms) {
			return 23+(ms.Stats[1]-10)/2;
		}
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