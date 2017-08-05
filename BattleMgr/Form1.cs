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
        public Form1()
        {
            InitializeComponent();
        }

        public void ReloadInitiative()
        {
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
                    initPanel.Controls.Clear();
                    ReloadInitiative();
                    
                }
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            initPanel.Controls.Clear();
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
            }

        }
    }
}
