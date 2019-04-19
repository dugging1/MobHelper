using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobHelper.Mobs;

namespace MobHelper.Mobs {
    class BlackJackel : TaoMob {
        protected override IMobStatBlock Stats {
            get {
                return new MobStats().New(new int[7] {
                    16+MobRollHelper.roll(2, 4),    //STR
                    11+MobRollHelper.roll(1, 6),     //DEX
                    6+MobRollHelper.roll(1, 4)/2,   //INT
					6+MobRollHelper.roll(1, 4)/2,   //WIS
                    10+MobRollHelper.roll(2, 4),     //CON
                    MobRollHelper.roll(1, 4), 0 },  //CHR
                    "Black Jackel");
            }
        }
        protected override int startHP { get { return 30; } }
        protected override int HPDice { get { return 6; } }

        public override int getAC(IMobStatBlock ms) {
            return 13+(ms.Stats[1]-10)/2;
        }
    }
}

/* 
 * Encounters: [1+1d4]
 * 
 * Attacks:
 * Bite: [2d8+Str.]
 * Claw: [2d6+Dex.]
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
