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
    public partial class Women : Form
    {
        public Women()
        {
            InitializeComponent();
        }

        private void TTTbtn_Click(object sender, EventArgs e)
        {
            Womanbody womanbody = new Womanbody();
            this.Hide();
            womanbody.Show();
        }

        private void CSCbtn_Click(object sender, EventArgs e)
        {
            WomanLegs womanlegs = new WomanLegs();
            this.Hide();
            womanlegs.Show();
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
