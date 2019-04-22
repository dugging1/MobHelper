using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace MobHelper.UI {
	public partial class MobRollerBtnPanel : Panel {
		private MobRollerPanel layout;

		public override LayoutEngine LayoutEngine {
			get {
				if (layout == null)
					layout = new MobRollerPanel();

				return layout;
			}
		}

		public override bool AutoScroll {
			get { return true; }
			set { base.AutoScroll=value; }
		}

		public MobRollerBtnPanel() {
			InitializeComponent();
		}
	}

	public class MobRollerPanel : LayoutEngine {
		public override bool Layout(object container, LayoutEventArgs layoutEventArgs) {
			Control parent = container as Control;

			Rectangle parentDisplayRectangle = parent.DisplayRectangle;
			Point nextControlLocation = parentDisplayRectangle.Location;

			List<Control> cs = new List<Control>();
			foreach (Control control in parent.Controls) {
				if (control.Visible) cs.Add(control);
			}

			cs.Sort(new Comparison<Control>((Control x, Control y) => x.Text.CompareTo(y.Text)));

			foreach (Control c in cs) {
				nextControlLocation.Offset(c.Margin.Left, c.Margin.Top);
				c.Location = nextControlLocation;

				if (c.AutoSize) c.Size = c.GetPreferredSize(parentDisplayRectangle.Size);

				nextControlLocation.X = parentDisplayRectangle.X;
				nextControlLocation.Y += c.Height + c.Margin.Bottom;
			}

			return false;
		}
	}
}
