﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobHelper.Model;

namespace TaoMobs {
	class JadeCondor : TaoMob {
		public JadeCondor() : base() {
			IStats s = (IStats)getComponent(typeof(IStats));
			s.Strength = 8+MobRollHelper.roll(2, 4);
			s.Dexterity = 15+MobRollHelper.roll(2, 8);
			s.Intelligence = 4+MobRollHelper.roll(1, 4);
			s.Wisdom = 8+MobRollHelper.roll(1, 4);
			s.Constitution = 10+MobRollHelper.roll(1, 6);
			s.Charisma = 6+MobRollHelper.roll(1, 4);
			s.Speed = 40;
			s.AC = 11+(s.Dexterity-10)/2;
			s.HP = MobRollHelper.addHp(this, startHP, HPDice, 1);
		}

		protected int startHP { get { return 30; } }

		protected int HPDice { get { return 6; } }

		public override string Name {
			get { return "Jade Condor"; }
		}
	}
}

/*
 * Encounters: [1+(1d4)/2]
 * 
 * Attacks:
 * Swoop: Adds extra damage to other attacks.
 * Claw: [2d8+dex.] ([+3d4] after swoop).
 * 
 */
