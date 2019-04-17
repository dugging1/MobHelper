using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobHelper.Mobs {
	public interface IMobStatBlock {
		int[] Stats { get; set; }
		string Name { get; set; }
		int Number { get; set; }

		IMobStatBlock New(int[] stats, string name, int number);
	}
}
