
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobHelper.Model {
	public interface IRollAction {

		/// <summary>
		/// Text for the button.
		/// </summary>
		string Name { get; }

		/// <summary>
		/// @return
		/// </summary>
		int roll();

	}
}