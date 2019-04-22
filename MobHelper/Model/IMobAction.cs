
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobHelper.Model {
	public interface IMobAction {

		HashSet<IRollAction> rollActions { get; }


	}
}