using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleMgr
{
    public partial class Form1 : Form
    {
        List<Initiative> initiatives = new List<Initiative>();
        List<Monster> monsters = new List<Monster>();

        public Form1()
        {
            InitializeComponent();
        }

        public void ReloadInitiative()
        {
            initPanel.Controls.Clear();
            for (int i = 0; i < initiatives.Count; i++)
            {
                Label namelbl = new Label();
                namelbl.Text = initiatives[i].name;
                initPanel.Controls.Add(namelbl);

                Label initlbl = new Label();
                initlbl.Text = initiatives[i].init.ToString();
                initPanel.Controls.Add(initlbl);

                Label dexlbl = new Label();
                dexlbl.Text = initiatives[i].dex.ToString();
                initPanel.Controls.Add(dexlbl);

                //newline part
                initPanel.SetFlowBreak(dexlbl, true);
            }
        }

        public void ReloadMonsters()
        {
            mstrPanel.Controls.Clear();
            for (int i = 0; i < monsters.Count; i++)
            {
                Label namelbl = new Label();
                namelbl.Text = monsters[i].name;
                mstrPanel.Controls.Add(namelbl);

                NumericUpDown hpUd = new NumericUpDown();
                hpUd.Maximum = 1000;
                hpUd.Minimum = 0;
                hpUd.Width = 50;
                hpUd.Value = monsters[i].hit_points;
                mstrPanel.Controls.Add(hpUd);

                Button infoBtn = new Button();
                infoBtn.Text = "...";
                infoBtn.Width = 30;
                mstrPanel.Controls.Add(infoBtn);

                //newline part
                mstrPanel.SetFlowBreak(infoBtn, true);
            }
        }

        private void addInitBtn_Click_1(object sender, EventArgs e)
        {
            Initiative initInst = new Initiative();
            using (var addForm = new AddInitiative())
            {
                var result = addForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    // Get the data from add form
                    initInst.name = addForm.nameEntry;
                    initInst.dex = addForm.dexEntry;
                    initInst.init = addForm.initEntry;
                    initiatives.Add(initInst);
                    initiatives = initiatives.OrderByDescending(x => x.init).ThenByDescending(x => x.dex).ToList<Initiative>();
                    ReloadInitiative();
                    
                }
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            initiatives.Clear();
        }

        private void removeCb_CheckedChanged(object sender, EventArgs e)
        {
            initPanel.Controls.Clear();
            if (removeCb.Checked)
            {
                for (int i = 0; i < initiatives.Count; i++)
                {
                    Initiative currInitiative = initiatives[i];
                    Button rm = new Button();
                    rm.Text = "Remove:";
                    rm.AutoSize = true;
                    initPanel.Controls.Add(rm);

                    Label namelbl = new Label();
                    namelbl.Text = initiatives[i].name;
                    initPanel.Controls.Add(namelbl);

                    Label initlbl = new Label();
                    initlbl.Text = initiatives[i].init.ToString();
                    initPanel.Controls.Add(initlbl);

                    Label dexlbl = new Label();
                    dexlbl.Text = initiatives[i].dex.ToString();
                    initPanel.Controls.Add(dexlbl);
                    //newline part              
                    initPanel.SetFlowBreak(dexlbl, true);
                    rm.Click += (s, ea) =>
                    {
                        initiatives.Remove(currInitiative);
                        initPanel.Controls.Remove(rm);
                        initPanel.Controls.Remove(namelbl);
                        initPanel.Controls.Remove(initlbl);
                        initPanel.Controls.Remove(dexlbl);
                    };

                }

            }
            else
            {
                ReloadInitiative();
            }
        }

        private void addMstrBtn_Click(object sender, EventArgs e)
        {
            using (var addForm = new AddMstr())
            {
                addForm.LoadMstrCb();
                var result = addForm.ShowDialog();
                if (result == DialogResult.OK) {
                    if (addForm.autoInitRoll)
                    {
                        AutoRollInit(addForm.mstrEntry);
                    }
                    for (int i = 0; i < addForm.numGen; i++)
                    {
                        Monster monst = new Monster(addForm.mstrEntry);
                        
                        if (addForm.numGen > 1)
                        {
                            monst.name = monst.name + i;
                        }
                        monsters.Add(monst);
                        //Add monster information to form
                    }
                    ReloadMonsters();
                }
                else if (result == DialogResult.Retry)
                {
                    GenerateCustomMonster();
                }
            }

        }

        private void GenerateCustomMonster()
        {
            using (var addForm = new CustomMonster())
            {
                var result = addForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    if (addForm.autoInitRoll)
                    {
                        AutoRollInit(addForm.custMstr);
                    }
                    for (int i = 0; i < addForm.numGen; i++)
                    {
                        Monster monst = new Monster(addForm.custMstr);
                        if (addForm.numGen > 1)
                        {
                            monst.name = monst.name + i;
                        }
                        monsters.Add(monst);
                    }
                }
            }
        }

        private void AutoRollInit(Monster m)
        {
            int dexMod = CalcMod(m.dexterity);
            Random rnd = new Random();
            int roll = rnd.Next(1, 21);
            Initiative init = new Initiative();
            init.name = m.name;
            init.init = roll;
            init.dex = dexMod;
            initiatives.Add(init);
            ReloadInitiative();

        }

        private int CalcMod(int i)
        {
            int mod = Convert.ToInt32(Math.Floor((i - 10.0)/2.0));
            return mod;
        }

        private void clearMstr_Click(object sender, EventArgs e)
        {
            monsters.Clear();
        }
    }
}
