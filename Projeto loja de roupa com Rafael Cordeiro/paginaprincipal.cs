using System.Net.Sockets;

namespace Projeto_loja_de_roupa_com_Rafael_Cordeiro
{
    public partial class paginaprincipal : Form
    {
        public paginaprincipal()
        {
            InitializeComponent();
            itens_carrinho.AtualizarLabelComContagem(numero_itens);
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
                loginbtn.Visible = false;
                loginbtn.Enabled = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LogIN login = new LogIN();
            this.Hide();
            login.Show();
        }
        private void menbtn_Click(object sender, EventArgs e)
        {
            Men men = new Men();
            this.Hide();
            men.Show();
        }
        private void womenbtn_Click(object sender, EventArgs e)
        {
            Women women = new Women();
            this.Hide();
            women.Show();
        }
        private void bttn_sair_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
        private void bttn_carrinho_Click_1(object sender, EventArgs e)
        {
            carrinho pagar = new carrinho();
            this.Hide();
            pagar.Show();
        }
    }
}