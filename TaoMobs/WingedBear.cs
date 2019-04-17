using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobHelper.Mobs;

namespace MobHelper.Mobs {
    class WingedBear : TaoMob {
        protected override IMobStatBlock Stats {
            get {
                return new MobStats().New(new int[7] {
                    16+MobRollHelper.roll(2, 3),    //STR
                    8+MobRollHelper.roll(2, 4),     //DEX
                    4+MobRollHelper.roll(1, 4)/2,   //INT
					4+MobRollHelper.roll(1, 4)/2,   //WIS
                    8+MobRollHelper.roll(1, 4),     //CON
                    MobRollHelper.roll(1, 6), 0 },  //CHR
                    "Winged Bear");
            }
        }
        protected override int startHP { get { return 30; } }
        protected override int HPDice { get { return 10; } }
        protected override int NumHPDice { get { return 4; } }

        public override int getAC(IMobStatBlock ms) {
            return 15+(ms.Stats[1]-10)/2;
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
 * Attack :
 * Charged Swipe
 * Chain Swipe
 * Empowered Jaw
 * 
 */
