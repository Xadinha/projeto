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
    public partial class LogIN : Form
    {
        public LogIN()
        {
            InitializeComponent();
        }

        private void LogIN_Load(object sender, EventArgs e)
        {

        }

        private void ANTCRbtn_Click(object sender, EventArgs e)
        {
            Registar registar = new Registar();
            registar.Show();
        }
    }
}
