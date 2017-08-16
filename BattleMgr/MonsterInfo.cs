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
        public MonsterInfo()
        {
            InitializeComponent();
        }

        public void SetupMonsterInfo(Monster m)
        {
            mstrName.Text = m.name;
            mstrSize.Text = m.size;
            mstrType.Text = m.type;
            mstrAC.Text = m.armor_class.ToString();
            mstrHP.Text = m.hit_points.ToString();
        }
    }
}
