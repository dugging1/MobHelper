using MobHelper.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrimsonBloodlineMobs {
	static class Program {
		[STAThread]
		static void Main(string[] args) {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			MainForm mf = new MainForm();
			//mf.FormBorderStyle = FormBorderStyle.FixedDialog;

			Application.Run(mf);
		}
	}
}
