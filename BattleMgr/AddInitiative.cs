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
    public partial class AddInitiative : Form
    {
        public string nameEntry = "";
        public int initEntry = 0;
        public int dexEntry = 0;

        public AddInitiative()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(nameTb.Text))
            {
                this.nameEntry = nameTb.Text;
                this.initEntry = Convert.ToInt32(initUd.Value);
                this.dexEntry = Convert.ToInt32(dexUd.Value);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                errMsg.Visible = true;
                var t = new Timer();
                t.Interval = 3000;
                t.Tick += (s, v) =>
                {
                    errMsg.Visible = false;
                    t.Stop();
                };
                t.Start();
            }
        }

        private void initUd_Enter(object sender, EventArgs e)
        {
            initUd.Select(0, initUd.Text.Length);
        }

        private void dexUd_Enter(object sender, EventArgs e)
        {
            dexUd.Select(0, dexUd.Text.Length);
        }
    }
}
