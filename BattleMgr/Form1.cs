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
                TextBox namelbl = new TextBox();
                namelbl.ReadOnly = true;
                namelbl.Text = initiatives[i].name;
                initPanel.Controls.Add(namelbl);

                NumericUpDown initlbl = new NumericUpDown();
                initlbl.ReadOnly = true;
                initlbl.Value = Convert.ToInt32(initiatives[i].init);
                initlbl.Width = 50;
                initlbl.Maximum = 100;
                initlbl.Minimum = -100;
                initPanel.Controls.Add(initlbl);

                NumericUpDown dexlbl = new NumericUpDown();
                dexlbl.ReadOnly = true;
                dexlbl.Width = 50;
                dexlbl.Maximum = 100;
                dexlbl.Minimum = -100;
                dexlbl.Value = Convert.ToInt32(initiatives[i].dex);
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
                Monster mstr = monsters[i];

                TextBox namelbl = new TextBox();
                namelbl.ReadOnly = true;
                namelbl.Text = mstr.name;
                mstrPanel.Controls.Add(namelbl);

                NumericUpDown hpUd = new NumericUpDown();
                hpUd.Maximum = 1000;
                hpUd.Minimum = 0;
                hpUd.Width = 50;
                hpUd.Value = mstr.currHP;
                mstrPanel.Controls.Add(hpUd);
                hpUd.ValueChanged += (s, ea) =>
                {
                    mstr.currHP = Convert.ToInt32(hpUd.Value);
                };

                TextBox currcond = new TextBox();
                currcond.Width = 150;
                mstrPanel.Controls.Add(currcond);

                Button infoBtn = new Button();
                infoBtn.Text = "...";
                infoBtn.Width = 30;
                mstrPanel.Controls.Add(infoBtn);

                infoBtn.Click += (s, ea) =>
                {
                    MonsterInfo mstrInfo = new MonsterInfo();
                    mstrInfo.m = mstr;
                    mstrInfo.SetupMonsterInfo();
                    mstrInfo.Show();
                };



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
            ReloadInitiative();
        }

        private void removeCb_CheckedChanged(object sender, EventArgs e)
        {
            initPanel.Controls.Clear();
            if (removeCb.Checked)
            {
                for (int i = 0; i < initiatives.Count; i++)
                {
                    Initiative currInitiative = initiatives[i];


                    TextBox namelbl = new TextBox();
                    namelbl.ReadOnly = true;
                    namelbl.Text = initiatives[i].name;
                    initPanel.Controls.Add(namelbl);

                    NumericUpDown initlbl = new NumericUpDown();
                    initlbl.ReadOnly = true;
                    initlbl.Width = 50;
                    initlbl.Maximum = 100;
                    initlbl.Minimum = -100;
                    initlbl.Value = Convert.ToInt32(initiatives[i].init);
                    initPanel.Controls.Add(initlbl);

                    NumericUpDown dexlbl = new NumericUpDown();
                    dexlbl.ReadOnly = true;
                    dexlbl.Width = 50;
                    dexlbl.Maximum = 100;
                    dexlbl.Minimum = -100;
                    dexlbl.Value = Convert.ToInt32(initiatives[i].dex);
                    initPanel.Controls.Add(dexlbl);
                    //newline part              


                    Button rm = new Button();
                    try
                    {
                        rm.Image = Image.FromFile("data/remove-icon.ico");
                    }
                    catch (Exception)
                    {
                        rm.Text = "Remove";
                    }                      
                    rm.Width = 25;
                    initPanel.Controls.Add(rm);
                    initPanel.SetFlowBreak(rm, true);
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
                    ReloadMonsters();
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
            init.dex = dexMod;
            init.init = roll + dexMod;
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
            ReloadMonsters();
        }

        private void rmMstr_CheckedChanged(object sender, EventArgs e)
        {
            mstrPanel.Controls.Clear();
            if (rmMstr.Checked)
            {
                for (int i = 0; i < monsters.Count; i++)
                {
                    Monster currMstr = monsters[i];


                    TextBox namelbl = new TextBox();
                    namelbl.ReadOnly = true;
                    namelbl.Text = currMstr.name;
                    mstrPanel.Controls.Add(namelbl);

                    NumericUpDown hpUd = new NumericUpDown();
                    hpUd.Maximum = 1000;
                    hpUd.Minimum = 0;
                    hpUd.Width = 50;
                    hpUd.Value = currMstr.currHP;
                    mstrPanel.Controls.Add(hpUd);

                    hpUd.ValueChanged += (s, ea) =>
                    {
                        currMstr.currHP = Convert.ToInt32(hpUd.Value);
                    };

                    TextBox currcond = new TextBox();
                    currcond.Width = 150;
                    mstrPanel.Controls.Add(currcond);

                    Button infoBtn = new Button();
                    infoBtn.Text = "...";
                    infoBtn.Width = 30;
                    mstrPanel.Controls.Add(infoBtn);

                    infoBtn.Click += (s, ea) =>
                    {
                        MonsterInfo mstrInfo = new MonsterInfo();
                        mstrInfo.m = currMstr;
                        mstrInfo.SetupMonsterInfo();
                        mstrInfo.Show();
                    };

                    Button rm = new Button();
                    rm.Image = Image.FromFile("data/remove-icon.ico");
                    rm.Width = 25;
                    mstrPanel.Controls.Add(rm);

                    mstrPanel.SetFlowBreak(rm, true);
                    rm.Click += (s, ea) =>
                    {
                        monsters.Remove(currMstr);
                        mstrPanel.Controls.Remove(rm);
                        mstrPanel.Controls.Remove(namelbl);
                        mstrPanel.Controls.Remove(hpUd);
                        mstrPanel.Controls.Remove(currcond);
                        mstrPanel.Controls.Remove(infoBtn);
                    };

                }

            }
            else
            {
                ReloadMonsters();
            }
        }
    }
}
