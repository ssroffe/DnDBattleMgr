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

        public void LoadMstrCb()
        {
            string json;
            using (StreamReader r = new StreamReader("../../data/monsters.json"))
            {
                json = r.ReadToEnd();
            }
            List<Monster> mstrList = JsonConvert.DeserializeObject<List<Monster>>(json);
            foreach (Monster mstr in mstrList)
            {
                mstrCb.Items.Add(mstr.name);
            }
        }
        public AddMstr()
        {
            InitializeComponent();
        }
    }
}
