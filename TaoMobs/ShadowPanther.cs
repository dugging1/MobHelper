using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobHelper.Model;

namespace TaoMobs {
	class ShadowPanther : TaoMob {
		public ShadowPanther() : base() {
			Name = "Shadow Panther";
			IStats s = (IStats)getComponent(typeof(IStats));
			s.Strength = 12+MobRollHelper.roll(3, 4);
			s.Dexterity = 15+MobRollHelper.roll(2, 6);
			s.Intelligence = 2+MobRollHelper.roll(1, 8);
			s.Wisdom = 8+MobRollHelper.roll(2, 4);
			s.Constitution = 14+MobRollHelper.roll(1, 4);
			s.Charisma = 4+MobRollHelper.roll(1, 6);
			s.Speed = 40;
			s.AC = 11+Convert.ToInt32(Math.Floor((s.Dexterity-10.0)/2.0));
			s.HP = MobRollHelper.addHp(this, startHP, HPDice, 1);
		}
		public ShadowPanther(string name, int num, ImmutableHashSet<IComponent> comps) : this() {
			Name = name;
			Number = num;
			Components = comps;
		}
		public override IMob New(string name, int number, ImmutableHashSet<IComponent> comps) => new ShadowPanther(name, number, comps);

		protected int startHP { get { return 50; } }

		protected int HPDice { get { return 20; } }
	}
}