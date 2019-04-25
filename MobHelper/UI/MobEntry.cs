using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using MobHelper.Model;

namespace MobHelper.UI {
	public partial class MobEntry : UserControl, IMobDisplayBlock {
		public MobEntry(IMob ms) {
			InitializeComponent();

			IStats s = (IStats)ms.getComponent(typeof(IStats));
			Mob = ms;

			mobType.Text = ms.Name;
			mobNumber.Text = ms.Number.ToString();
			Str.Text = s.Strength.ToString();
			Dex.Text = s.Dexterity.ToString();
			Int.Text = s.Intelligence.ToString();
			Wis.Text = s.Wisdom.ToString();
			Con.Text = s.Constitution.ToString();
			Cha.Text = s.Charisma.ToString();
			Hp.Text = s.HP.ToString();
			AC.Text = s.AC.ToString();
		}

		public Color BackColour { get; set; }

		public Color ForeColour { get; set; }

		public IMob Mob { get; set; }

		private void button1_Click(object sender, System.EventArgs e) {
			Thread t = new Thread(new ParameterizedThreadStart(newMobForm));
			t.Start(Mob);
		}

		private void newMobForm(object m) {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MobForm((IMob)m));
		}
	}
}
