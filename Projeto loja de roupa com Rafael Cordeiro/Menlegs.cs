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
    public partial class Menlegs : Form
    {
        public Menlegs()
        {
            InitializeComponent();
        }

        private void bttn_sair_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void bttn_anterior_Click(object sender, EventArgs e)
        {
            Men men = new Men ();
            this.Hide();
            men.Show();
        }
    }
}
