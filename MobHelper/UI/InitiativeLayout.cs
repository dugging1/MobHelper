using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace MobHelper.UI {

	public class InitiativePanel : Panel {
		private InitiativeLayout layout;

		public override LayoutEngine LayoutEngine {
			get {
				if (layout == null)
					layout = new InitiativeLayout();

				return layout;
			}
		}

		public override bool AutoScroll {
			get {return true;}
			set {base.AutoScroll=value;}
		}
	}

	public class InitiativeLayout:LayoutEngine {
		public override bool Layout(object container, LayoutEventArgs layoutEventArgs) {
			Control parent = container as Control;

			Rectangle parentDisplayRectangle = parent.DisplayRectangle;
			Point nextControlLocation = parentDisplayRectangle.Location;

			List<InitiativeEntry> cs = new List<InitiativeEntry>();
			foreach (Control control in parent.Controls) {
				if(control.Visible) cs.Add((InitiativeEntry)control);
			}

			cs.Sort();
			cs.Reverse();

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
