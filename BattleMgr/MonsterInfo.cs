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
    public partial class MonsterInfo : Form
    {
        public Monster m = new Monster();

        public MonsterInfo()
        {
            InitializeComponent();
        }

        public void SetupMonsterInfo()
        {
            mstrName.Text = m.name;
            mstrSize.Text = m.size;
            mstrType.Text = m.type;
            mstrAlignment.Text = m.alignment;
            mstrAC.Text = m.armor_class.ToString();
            mstrHP.Text = m.hit_points.ToString();
            mstrSpeed.Text = m.speed;

            mstrStr.Text = m.strength.ToString();
            mstrStrMod.Text = "(" + ModFormat(m.strength) + ")";
            mstrDex.Text = m.dexterity.ToString();
            mstrDexMod.Text = "(" + ModFormat(m.dexterity) + ")";
            mstrCons.Text = m.constitution.ToString();
            mstrConsMod.Text = "(" + ModFormat(m.constitution) + ")";
            mstrInt.Text = m.intelligence.ToString();
            mstrIntMod.Text = "(" + ModFormat(m.intelligence) + ")";
            mstrWis.Text = m.wisdom.ToString();
            mstrWisMod.Text = "(" + ModFormat(m.wisdom) + ")";
            mstrChar.Text = m.charisma.ToString();
            mstrCharMod.Text = "(" + ModFormat(m.charisma) + ")";

            mstrDmgImm.Text = m.damage_immunities;
            mstrDmgRes.Text = m.damage_resistances;
            mstrDmgVuln.Text = m.damage_vulnerabilities;
            mstrCondImm.Text = m.condition_immunities;

            mstrSenses.Text = m.senses;
            mstrLanguages.Text = m.languages;
            mstrChallenge.Text = m.challenge_rating.ToString();

            mstrNotes.Text = m.notes;

            
            for (int i = 0; i < m.actions.Count; i++)
            {
                mstrActions.Text += m.actions[i].print();
                mstrActions.Text += Environment.NewLine;
                mstrActions.Text += Environment.NewLine;
            }
            for (int i = 0; i < m.special_abilities.Count; i++)
            {
                mstrSpecAbil.Text += m.special_abilities[i].print();
                mstrSpecAbil.Text += Environment.NewLine;
                mstrSpecAbil.Text += Environment.NewLine;
            }
            for (int i = 0; i < m.legendary_actions.Count; i++)
            {
                mstrLegenAct.Text += m.legendary_actions[i].print();
                mstrLegenAct.Text += Environment.NewLine;
                mstrLegenAct.Text += Environment.NewLine;
            }
            
        }
        private string ModFormat(int i)
        {
            int c = Convert.ToInt32(Math.Floor((i - 10.0) / 2.0));
            string mod = c.ToString("+0;-#");
            return mod;
        }

        private void mstrNotes_TextChanged(object sender, EventArgs e)
        {
            m.notes = mstrNotes.Text;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
