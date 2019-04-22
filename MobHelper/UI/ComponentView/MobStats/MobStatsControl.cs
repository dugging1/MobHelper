using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobHelper.UI.ComponentView.MobStats {
	public partial class MobStatsControl : UserControl {
		public MobStatsControl(Model.MobStats s) {
			InitializeComponent();

			StrScore.Text = s.Strength.ToString();
			StrMod.Text = Convert.ToInt32(Math.Floor((s.Strength-10.0)/2.0)).ToString();

			DexScore.Text = s.Dexterity.ToString();
			DexMod.Text = Convert.ToInt32(Math.Floor((s.Dexterity-10.0)/2.0)).ToString();

			ConScore.Text = s.Constitution.ToString();
			ConMod.Text = Convert.ToInt32(Math.Floor((s.Constitution-10.0)/2.0)).ToString();

			IntScore.Text = s.Intelligence.ToString();
			IntMod.Text = Convert.ToInt32(Math.Floor((s.Intelligence-10.0)/2.0)).ToString();

			WisScore.Text = s.Wisdom.ToString();
			WisMod.Text = Convert.ToInt32(Math.Floor((s.Wisdom-10.0)/2.0)).ToString();

			ChaScore.Text = s.Charisma.ToString();
			ChaMod.Text = Convert.ToInt32(Math.Floor((s.Charisma-10.0)/2.0)).ToString();

			Speed.Text = s.Speed.ToString();

			HP.Text = s.HP.ToString();

			AC.Text = s.AC.ToString();
		}
	}
}
