using System.Drawing;
using System.Windows.Forms;
using MobHelper.Mobs;

namespace MobHelper.UI {
	public partial class MobEntry : UserControl, IMobDisplayBlock {
		public MobEntry(IMobStatBlock ms) {
			InitializeComponent();
			Stats = ms;
			mobType.Text = ms.Name;
			mobNumber.Text = ms.Number.ToString();
			Str.Text = ms.Stats[0].ToString();
			Dex.Text = ms.Stats[1].ToString();
			Int.Text = ms.Stats[2].ToString();
			Wis.Text = ms.Stats[3].ToString();
			Con.Text = ms.Stats[4].ToString();
			Cha.Text = ms.Stats[5].ToString();
			Hp.Text = ms.Stats[6].ToString();
			AC.Text = ms.Stats[7].ToString();
		}

		public Color BackColour { get; set; }

		public Color ForeColour { get; set; }

		public IMobStatBlock Stats { get; set; }
	}
}
