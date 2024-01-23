using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Projeto_loja_de_roupa_com_Rafael_Cordeiro
{
    public partial class LogIN : Form
    {
        private string nome = "admin";
        private string password = "admin";
        public LogIN()
        {
            InitializeComponent();
            PASStxt.UseSystemPasswordChar = true;
        }
        private void ANTCRbtn_Click(object sender, EventArgs e)
        {
            Registar registar = new Registar();
            this.Hide();
            registar.Show();
            nome = registar.NovoNome;
            password = registar.NovaPassword;
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
        private void CONFIRMARbtn_Click(object sender, EventArgs e)
        {
            string inputNome = NUtxt.Text;
            string inputPassword = PASStxt.Text;

            if (inputNome == nome && inputPassword == password)
            {
                MessageBox.Show("Login bem-sucedido!");
            }
            else
            {
                MessageBox.Show("Falha no login. Verifique suas credenciais.");
            }
        }
        private void checkPASS_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPASS.Checked)
            {
                PASStxt.UseSystemPasswordChar = false;
            }
            else
            {
                PASStxt.UseSystemPasswordChar = true;
            }
        }
    }
}
