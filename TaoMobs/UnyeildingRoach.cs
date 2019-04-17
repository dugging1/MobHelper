using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobHelper.Mobs;

namespace MobHelper.Mobs {
    class UnyeildingRoach : TaoMob {
        protected override IMobStatBlock Stats {
            get {
                return new MobStats().New(new int[7] {
                    4+MobRollHelper.roll(2, 4),    //STR
                    2+MobRollHelper.roll(1, 6),     //DEX
                    4+MobRollHelper.roll(1, 4)/2,   //INT
					4+MobRollHelper.roll(1, 4)/2,   //WIS
                    2+MobRollHelper.roll(2, 4),     //CON
                    MobRollHelper.roll(1, 4)-4, 0 },  //CHR
                    "Unyeilding Roach");
            }
        }
        protected override int startHP { get { return 2; } }
        protected override int HPDice { get { return 6; } }
        protected override int NumHPDice { get { return 10; } }

        public override int getAC(IMobStatBlock ms) {
            return 20+(ms.Stats[1]-10)/2;
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
 * Skin crawl
 * Bite
 * Scratch
 * 
 */
