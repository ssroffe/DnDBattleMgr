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
        public Monster mstrEntry = new Monster();
        public int numGen = 0;
        public bool autoInitRoll = false;

        public void LoadMstrCb()
        {
            string json;
            try
            {
                using (StreamReader r = new StreamReader("data/monsters.json"))
                {
                    json = r.ReadToEnd();
                }
                mstrList = JsonConvert.DeserializeObject<List<Monster>>(json);
                foreach (Monster mstr in mstrList)
                {
                    mstrCb.Items.Add(mstr.name);
                }
            } catch (FileNotFoundException)
            {
                
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
                mstrEntry = mstrList.FirstOrDefault<Monster>(o => o.name == mstrCb.Text);
                if (mstrEntry != null)
                {
                    autoInitRoll = autoInit.Checked;
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
