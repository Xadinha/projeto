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
    public partial class WomanLegs : Form
    {
        public WomanLegs()
        {
            InitializeComponent();
            panel1.AutoScroll = false;
            panel1.HorizontalScroll.Enabled = false;
            panel1.HorizontalScroll.Visible = false;
            panel1.HorizontalScroll.Maximum = 0;
            panel1.AutoScroll = true;
            if (nome_utilizador.nomeutilizador == "")
            {
                LabelUtilizador.Visible = false;
                LabelUtilizador.Enabled = false;
            }
            else
            {
                LabelUtilizador.Enabled = true;
                LabelUtilizador.Text = nome_utilizador.nomeutilizador;
                LabelUtilizador.Visible = true;
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void bttn_anterior_Click(object sender, EventArgs e)
        {
            Women women = new Women();
            this.Hide();
            women.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void bttn_carrinho_Click(object sender, EventArgs e)
        {
            carrinho pagar = new carrinho();
            this.Hide();
            pagar.Show();
        }
    }
}
