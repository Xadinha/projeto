using System.Net.Sockets;

namespace Projeto_loja_de_roupa_com_Rafael_Cordeiro
{
    public partial class paginaprincipal : Form
    {
        public paginaprincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogIN login = new LogIN();
            login.Show();
        }

        private void menbtn_Click(object sender, EventArgs e)
        {
            Men men = new Men();
            men.Show();
        }

        private void womenbtn_Click(object sender, EventArgs e)
        {
            Women women = new Women();
            women.Show();
        }
    }
}