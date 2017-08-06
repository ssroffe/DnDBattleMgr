using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;


namespace BattleMgr
{
    public partial class AddMstr : Form
    {
        private List<Monster> mstrList;
        public Monster mstrEntry;
        public int numGen = 0;

        public void LoadMstrCb()
        {
            string json;
            using (StreamReader r = new StreamReader("../../data/monsters.json"))
            {
                json = r.ReadToEnd();
            }
            mstrList = JsonConvert.DeserializeObject<List<Monster>>(json);
            foreach (Monster mstr in mstrList)
            {
                mstrCb.Items.Add(mstr.name);
            }
        }
        public AddMstr()
        {
            InitializeComponent();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(mstrCb.Text))
            {
                mstrEntry = mstrList.Where<Monster>(f => f.name.Equals(mstrCb.SelectedValue)).FirstOrDefault<Monster>();
                numGen = Convert.ToInt32(numGenUd.Value);
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

        private void makeCustMstr_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Retry;
            this.Close();
        }
    }
}
