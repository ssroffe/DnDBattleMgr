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
    public partial class ConfirmClear : Form
    {
        public ConfirmClear()
        {
            InitializeComponent();
        }

        private void yesBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void noBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
