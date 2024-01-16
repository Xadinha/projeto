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
            womanbody.Show();
        }

        private void CSCbtn_Click(object sender, EventArgs e)
        {
            WomanLegs womanlegs = new WomanLegs();
            womanlegs.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o Form2

            if (formAnterior != null && !formAnterior.IsDisposed)
            {
                formAnterior.Show(); // Exibe o formulário anterior
            }
        }
    }
}
