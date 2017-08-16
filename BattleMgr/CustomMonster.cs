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
        public int numGen = 1;
        public bool autoInitRoll;

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

        private void numGenUd_Enter(object sender, EventArgs e)
        {
            numGenUd.Select(0, numGenUd.Text.Length);
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(nameTb.Text))
            {
                autoInitRoll = autoInit.Checked;
                numGen = Convert.ToInt32(numGenUd.Value);
                custMstr.name = nameTb.Text;
                custMstr.hit_points = Convert.ToInt32(hpUd.Value);
                custMstr.hit_dice = hitDiceTb.Text;
                custMstr.speed = speedTb.Text;
                custMstr.armor_class = Convert.ToInt32(acUd.Value);
                custMstr.strength = Convert.ToInt32(strUd.Value);
                custMstr.dexterity = Convert.ToInt32(dexUd.Value);
                custMstr.constitution = Convert.ToInt32(consUd.Value);
                custMstr.intelligence = Convert.ToInt32(intUd.Value);
                custMstr.wisdom = Convert.ToInt32(wisUd.Value);
                custMstr.charisma = Convert.ToInt32(charUd.Value);
                custMstr.senses = sensesTb.Text;
                custMstr.damage_immunities = dmgImmTb.Text;
                custMstr.damage_resistances = dmgResTb.Text;
                custMstr.damage_vulnerabilities = dmgVulnTb.Text;
                custMstr.condition_immunities = condImmTb.Text;
                custMstr.notes = notesTb.Text;

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

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
