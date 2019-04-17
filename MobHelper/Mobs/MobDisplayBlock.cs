using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobHelper.Mobs {
	public interface IMobDisplayBlock: IComponent, IDisposable {
		Color BackColour { get; set; }
		Color ForeColour { get; set; }
		IMobStatBlock Stats { get; set; }
	}
}
