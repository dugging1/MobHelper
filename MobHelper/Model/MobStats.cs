using MobHelper.UI.ComponentView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobHelper.Model {
	public class MobStats : IStats {
		protected int[] stats = new int[9];

		public MobStats() { }

		public MobStats(int[] stats) {
			this.stats = stats;
		}

		public int Strength {
			get { return stats[0]; }
			set { stats[0] = value; }
		}

		public int Dexterity {
			get { return stats[1]; }
			set { stats[1] = value; }
		}

		public int Intelligence {
			get { return stats[2]; }
			set { stats[2] = value; }
		}

		public int Wisdom {
			get { return stats[3]; }
			set { stats[3] = value; }
		}

		public int Constitution {
			get { return stats[4]; }
			set { stats[4] = value; }
		}

		public int Charisma {
			get { return stats[5]; }
			set { stats[5] = value; }
		}

		public int Speed {
			get { return stats[6]; }
			set { stats[6] = value; }
		}

		public int AC {
			get { return stats[7]; }
			set { stats[7] = value; }
		}

		public int HP {
			get { return stats[8]; }
			set { stats[8] = value; }
		}

		public string Name {
			get { return "Stats"; }
		}

		public string Description {
			get { return "The stats of the mob."; }
		}

		protected componentViewFactory gen = new componentViewFactory();
		public componentViewFactory Generator { get { return gen; } }

		public IComponentView visit(componentViewFactory gen) {
			return gen.generate(this);
		}
	}
}