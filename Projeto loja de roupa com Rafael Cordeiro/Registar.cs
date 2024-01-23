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
    public partial class Registar : Form
    {
        public string NovoNome { get; private set; }
        public string NovaPassword { get; private set; }
        public Registar()
        {
            InitializeComponent();
            PASStxt.UseSystemPasswordChar = true;
            CPASStxt.UseSystemPasswordChar = true;
        }
        private void bttn_sair_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
        private void bttn_anterior_Click(object sender, EventArgs e)
        {
            LogIN login = new LogIN();
            this.Hide();
            login.Show();
        }
        private void checkPASS2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPASS2.Checked)
            {
                PASStxt.UseSystemPasswordChar = false;
                CPASStxt.UseSystemPasswordChar = false;
            }
            else
            {
                PASStxt.UseSystemPasswordChar = true;
                CPASStxt.UseSystemPasswordChar = true;

            }
        }
        private void REGISTARbtn_Click(object sender, EventArgs e)
        {
            if (PASStxt.Text == CPASStxt.Text)
            {
                NovoNome = NUtxt.Text;
                NovaPassword = PASStxt.Text;
                MessageBox.Show($"Verificado como {NUtxt.Text}.");
                nome_utilizador.nomeutilizador = NUtxt.Text;
                paginaprincipal principal = new paginaprincipal();
                this.Hide();
                principal.Show();
            }
            else
            {
                MessageBox.Show("Passwords têm de ser iguais.");
            }
        }
    }
}
