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
            this.Hide();
            menbody.Show();
        }

        private void CCbtn_Click(object sender, EventArgs e)
        {
            Menlegs menlegs = new Menlegs();
            this.Hide();
            menlegs.Show();
        }

        private void Men_Load(object sender, EventArgs e)
        {

        }

        private void bttn_sair_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void bttn_anterior_Click(object sender, EventArgs e)
        {
            paginaprincipal principal = new paginaprincipal();
            this.Hide();
            principal.Show();
        }
    }
}
