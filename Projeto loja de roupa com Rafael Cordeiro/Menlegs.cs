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
            itens_carrinho.AtualizarLabelComContagem(numero_itens);
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
        private void bttn_sair_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void bttn_anterior_Click(object sender, EventArgs e)
        {
            Men men = new Men();
            this.Hide();
            men.Show();
        }

        private void bttn_carrinho_Click(object sender, EventArgs e)
        {
            carrinho pagar = new carrinho();
            this.Hide();
            pagar.Show();
        }

        private void MLbtn1_Click(object sender, EventArgs e)
        {
            string nome = "calças super baggy pretas";
            //string tamanho = checkedListBox1.CheckedItems[0].ToString();
            string tamanho = "M";
            string preço = label1.Text;
            itens_carrinho.MétodoCarrinho(nome, tamanho, preço);
            itens_carrinho.AtualizarLabelComContagem(numero_itens);
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MLbtn2_Click(object sender, EventArgs e)
        {
            string nome = "calças super baggy cinzas";
            //string tamanho = checkML2.CheckedItems[0].ToString();
            string tamanho = "M";
            string preço = label1.Text;
            itens_carrinho.MétodoCarrinho(nome, tamanho, preço);
            itens_carrinho.AtualizarLabelComContagem(numero_itens);
        }

        private void MLbtn3_Click(object sender, EventArgs e)
        {
            string nome = "calças super baggy azul claro";
            //string tamanho = checkML3.CheckedItems[0].ToString();
            string tamanho = "M";
            string preço = label1.Text;
            itens_carrinho.MétodoCarrinho(nome, tamanho, preço);
            itens_carrinho.AtualizarLabelComContagem(numero_itens);
        }

        private void MLbtn4_Click(object sender, EventArgs e)
        {
            string nome = "calças super baggy azul escuro";
            //string tamanho = checkML4.CheckedItems[0].ToString();
            string tamanho = "M";
            string preço = label1.Text;
            itens_carrinho.MétodoCarrinho(nome, tamanho, preço);
            itens_carrinho.AtualizarLabelComContagem(numero_itens);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
        }

        private void MLbtn5_Click(object sender, EventArgs e)
        {
            string nome = "calças skater pretas";
            //string tamanho = checkML5.CheckedItems[0].ToString();
            string tamanho = "M";
            string preço = label1.Text;
            itens_carrinho.MétodoCarrinho(nome, tamanho, preço);
            itens_carrinho.AtualizarLabelComContagem(numero_itens);
        }

        private void MLbtn6_Click(object sender, EventArgs e)
        {
            string nome = "calças skater azul escuro";
            //string tamanho = checkML6.CheckedItems[0].ToString();
            string tamanho = "M";
            string preço = label1.Text;
            itens_carrinho.MétodoCarrinho(nome, tamanho, preço);
            itens_carrinho.AtualizarLabelComContagem(numero_itens);
        }

        private void MLbtn7_Click(object sender, EventArgs e)
        {
            string nome = "calças skater azul claro";
            //string tamanho = checkML7.CheckedItems[0].ToString();
            string tamanho = "M";
            string preço = label1.Text;
            itens_carrinho.MétodoCarrinho(nome, tamanho, preço);
            itens_carrinho.AtualizarLabelComContagem(numero_itens);
        }

        private void MLbtn8_Click(object sender, EventArgs e)
        {
            string nome = "calças skater castanhas";
            //string tamanho = checkML8.CheckedItems[0].ToString();
            string tamanho = "M";
            string preço = label1.Text;
            itens_carrinho.MétodoCarrinho(nome, tamanho, preço);
            itens_carrinho.AtualizarLabelComContagem(numero_itens);
        }
    }
}
