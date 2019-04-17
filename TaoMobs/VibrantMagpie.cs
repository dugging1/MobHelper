using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobHelper.Mobs;

namespace MobHelper.Mobs {
    class VibrantMagpie : TaoMob {
        protected override IMobStatBlock Stats {
            get {
                return new MobStats().New(new int[7] {
                    10+MobRollHelper.roll(2, 4),    //STR
                    10+MobRollHelper.roll(2, 6),     //DEX
                    4+MobRollHelper.roll(1, 4)/2,   //INT
					2+MobRollHelper.roll(1, 4)/2,   //WIS
                    6+MobRollHelper.roll(2, 4),     //CON
                    MobRollHelper.roll(1, 6), 0 },  //CHR
                    "Vibrant Magpie");
            }
        }
        protected override int startHP { get { return 15; } }
        protected override int HPDice { get { return 5; } }
        protected override int NumHPDice { get { return 2; } }

        public override int getAC(IMobStatBlock ms) {
            return 14+(ms.Stats[1]-10)/2;
        }
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
