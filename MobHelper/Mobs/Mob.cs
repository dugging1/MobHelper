using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobHelper.Mobs;

namespace MobHelper.Mobs {
	public interface Mob {
		IMobStatBlock getMobStats(int number);
		int getAC(IMobStatBlock ms);
	}
}
