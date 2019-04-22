using MobHelper.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobHelper.UI {
	public interface IMobDisplayBlock: System.ComponentModel.IComponent, IDisposable {
		Color BackColour { get; set; }
		Color ForeColour { get; set; }
		IMob Mob { get; set; }
	}
}
