using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleMgr
{
    public partial class CustomMonster : Form
    {
        public Monster custMstr = new Monster();

        public CustomMonster()
        {
            InitializeComponent();
        }

        private void hpUd_Enter(object sender, EventArgs e)
        {
            hpUd.Select(0, hpUd.Text.Length);
        }

        private void acUd_Enter(object sender, EventArgs e)
        {
            acUd.Select(0, acUd.Text.Length);
        }

        private void strUd_Enter(object sender, EventArgs e)
        {
            strUd.Select(0, strUd.Text.Length);
        }

        private void dexUd_Enter(object sender, EventArgs e)
        {
            dexUd.Select(0, dexUd.Text.Length);
        }

        private void consUd_Enter(object sender, EventArgs e)
        {
            consUd.Select(0, consUd.Text.Length);
        }

        private void intUd_Enter(object sender, EventArgs e)
        {
            intUd.Select(0, intUd.Text.Length);
        }

        private void wisUd_Enter(object sender, EventArgs e)
        {
            wisUd.Select(0, wisUd.Text.Length);
        }

        private void charUd_Enter(object sender, EventArgs e)
        {
            charUd.Select(0, charUd.Text.Length);
        }
    }
}
