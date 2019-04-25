using MobHelper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobHelper.UI.ComponentView.Inventory {
	public interface IItemViewFactory {
		UserControl generate(IItem i);
	}
}
