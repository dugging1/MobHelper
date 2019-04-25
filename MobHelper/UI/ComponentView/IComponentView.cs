
using MobHelper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MobHelper.UI.ComponentView {
	public interface IComponentView {

		TabPage TP { get; }

		IComponent Component { get; }

	}
}