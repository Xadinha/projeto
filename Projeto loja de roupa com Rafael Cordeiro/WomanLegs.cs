using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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
        private void WLbtn1_Click(object sender, EventArgs e)
        {
            string nome = "calças super baggy pretas mulher";
            //string tamanho = checkedListBox1.CheckedItems[0].ToString();
            string tamanho = "M";
            string preço = label3.Text;
            itens_carrinho.MétodoCarrinho(nome, tamanho, preço);
            itens_carrinho.AtualizarLabelComContagem(numero_itens);
        }
        private void WLbtn2_Click(object sender, EventArgs e)
        {
            string nome = "calças super baggy cinzas mulher";
            //string tamanho = checkML2.CheckedItems[0].ToString();
            string tamanho = "M";
            string preço = label3.Text;
            itens_carrinho.MétodoCarrinho(nome, tamanho, preço);
            itens_carrinho.AtualizarLabelComContagem(numero_itens);
        }
        private void WLbtn3_Click(object sender, EventArgs e)
        {
            string nome = "calças super baggy azul claro mulher";
            //string tamanho = checkML3.CheckedItems[0].ToString();
            string tamanho = "M";
            string preço = label3.Text;
            itens_carrinho.MétodoCarrinho(nome, tamanho, preço);
            itens_carrinho.AtualizarLabelComContagem(numero_itens);
        }
        private void WLbtn4_Click(object sender, EventArgs e)
        {
            string nome = "calças super baggy azul escuro mulher";
            //string tamanho = checkML4.CheckedItems[0].ToString();
            string tamanho = "M";
            string preço = label3.Text;
            itens_carrinho.MétodoCarrinho(nome, tamanho, preço);
            itens_carrinho.AtualizarLabelComContagem(numero_itens);
        }
        private void WLbtn5_Click(object sender, EventArgs e)
        {
            string nome = "calças skater pretas mulher";
            //string tamanho = checkML5.CheckedItems[0].ToString();
            string tamanho = "M";
            string preço = label3.Text;
            itens_carrinho.MétodoCarrinho(nome, tamanho, preço);
            itens_carrinho.AtualizarLabelComContagem(numero_itens);
        }
        private void WLbtn6_Click(object sender, EventArgs e)
        {
            string nome = "calças skater azul escuro mulher";
            //string tamanho = checkML6.CheckedItems[0].ToString();
            string tamanho = "M";
            string preço = label3.Text;
            itens_carrinho.MétodoCarrinho(nome, tamanho, preço);
            itens_carrinho.AtualizarLabelComContagem(numero_itens);
        }
        private void WLbtn7_Click(object sender, EventArgs e)
        {
            string nome = "calças skater azul claro mulher";
            //string tamanho = checkML7.CheckedItems[0].ToString();
            string tamanho = "M";
            string preço = label3.Text;
            itens_carrinho.MétodoCarrinho(nome, tamanho, preço);
            itens_carrinho.AtualizarLabelComContagem(numero_itens);
        }
        private void WLbtn8_Click(object sender, EventArgs e)
        {
            string nome = "calças skater castanhas mulher";
            //string tamanho = checkML8.CheckedItems[0].ToString();
            string tamanho = "M";
            string preço = label3.Text;
            itens_carrinho.MétodoCarrinho(nome, tamanho, preço);
            itens_carrinho.AtualizarLabelComContagem(numero_itens);
        }
    }
}
