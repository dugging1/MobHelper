using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobHelper.Mobs;

namespace MobHelper.Mobs {
    class ToweringTortoise : TaoMob {
        protected override IMobStatBlock Stats {
            get {
                return new MobStats().New(new int[7] {
                    40+MobRollHelper.roll(5, 5),    //STR
                    10,     //DEX
                    35+MobRollHelper.roll(2, 8)/2,   //INT
					20+MobRollHelper.roll(2, 4)/2,   //WIS
                    8+MobRollHelper.roll(4, 4),     //CON
                    MobRollHelper.roll(8, 4), 0 },  //CHR
                    "Towering Tortoise");
            }
        }
        protected override int startHP { get { return 50; } }
        protected override int HPDice { get { return 5; } }
        protected override int NumHPDice { get { return 10; } }

        public override int getAC(IMobStatBlock ms) {
            return 40+(ms.Stats[1]-10)/2;
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
 * Spin
 * Snap
 */
