using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobHelper.Mobs;

namespace MobHelper.Mobs {
    class DeathBeetle : TaoMob {
        protected override IMobStatBlock Stats {
            get {
                return new MobStats().New(new int[7] {
                    2+MobRollHelper.roll(4, 5),    //STR
                    4+MobRollHelper.roll(1, 6),     //DEX
                    15,   //INT
					15,   //WIS
                    8+MobRollHelper.roll(2, 4),     //CON
                    MobRollHelper.roll(1, 4)-5, 0 },  //CHR
                    "Death Beetle");
            }
        }
        protected override int startHP { get { return 2; } }
        protected override int HPDice { get { return 2; } }
        protected override int NumHPDice { get { return MobRollHelper.roll(1, 6); } }

        public override int getAC(IMobStatBlock ms) {
            return 10+(ms.Stats[1]-10)/2;
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
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 */
