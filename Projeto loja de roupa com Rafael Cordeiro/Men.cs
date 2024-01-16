using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_loja_de_roupa_com_Rafael_Cordeiro
{
    public partial class Men : Form
    {
        public Men()
        {
            InitializeComponent();
        }

        private void TSbtn_Click(object sender, EventArgs e)
        {
            MenBody menbody = new MenBody();
            menbody.Show();
        }

        private void CCbtn_Click(object sender, EventArgs e)
        {
            Menlegs menlegs = new Menlegs();
            menlegs.Show();
        }
    }
}
