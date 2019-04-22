
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobHelper.Model {
	public interface IStats:IComponent {
		int Strength { get; set; }
		int Dexterity { get; set; }
		int Intelligence { get; set; }
		int Wisdom { get; set; }
		int Constitution { get; set; }
		int Charisma { get; set; }

		int Speed { get; set; }

		int AC { get; set; }
		int HP { get; set; }
	}
}