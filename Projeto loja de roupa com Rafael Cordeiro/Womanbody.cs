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
    public partial class Womanbody : Form
    {
        public Womanbody()
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
            Women women = new Women();
            this.Hide();
            women.Show();
        }
        private void bttn_carrinho_Click(object sender, EventArgs e)
        {
            carrinho pagar = new carrinho();
            this.Hide();
            pagar.Show();
        }

        private void WBbtn1_Click(object sender, EventArgs e)
        {
            string nome = "sweat creme mulher";
            //string tamanho = checkedListBox1.CheckedItems[0].ToString();
            string tamanho = "M";
            string preço = label1.Text;
            itens_carrinho.MétodoCarrinho(nome, tamanho, preço);
            itens_carrinho.AtualizarLabelComContagem(numero_itens);
        }

        private void WBbtn2_Click(object sender, EventArgs e)
        {
            string nome = "sweat verde mulher";
            //string tamanho = checkedListBox1.CheckedItems[0].ToString();
            string tamanho = "M";
            string preço = label1.Text;
            itens_carrinho.MétodoCarrinho(nome, tamanho, preço);
            itens_carrinho.AtualizarLabelComContagem(numero_itens);
        }

        private void WBbtn3_Click(object sender, EventArgs e)
        {
            string nome = "casaco azul mulher";
            //string tamanho = checkedListBox1.CheckedItems[0].ToString();
            string tamanho = "M";
            string preço = label1.Text;
            itens_carrinho.MétodoCarrinho(nome, tamanho, preço);
            itens_carrinho.AtualizarLabelComContagem(numero_itens);
        }

        private void WBbtn4_Click(object sender, EventArgs e)
        {
            string nome = "sweat verde escuro mulher";
            //string tamanho = checkedListBox1.CheckedItems[0].ToString();
            string tamanho = "M";
            string preço = label1.Text;
            itens_carrinho.MétodoCarrinho(nome, tamanho, preço);
            itens_carrinho.AtualizarLabelComContagem(numero_itens);
        }

        private void WBbtn5_Click(object sender, EventArgs e)
        {
            string nome = "sweat castanha mulher";
            //string tamanho = checkedListBox1.CheckedItems[0].ToString();
            string tamanho = "M";
            string preço = label1.Text;
            itens_carrinho.MétodoCarrinho(nome, tamanho, preço);
            itens_carrinho.AtualizarLabelComContagem(numero_itens);
        }

        private void WBbtn6_Click(object sender, EventArgs e)
        {
            string nome = "sweat branca mulher";
            //string tamanho = checkedListBox1.CheckedItems[0].ToString();
            string tamanho = "M";
            string preço = label1.Text;
            itens_carrinho.MétodoCarrinho(nome, tamanho, preço);
            itens_carrinho.AtualizarLabelComContagem(numero_itens);
        }

        private void WBbtn7_Click(object sender, EventArgs e)
        {
            string nome = "sweat cinzenta mulher";
            //string tamanho = checkedListBox1.CheckedItems[0].ToString();
            string tamanho = "M";
            string preço = label1.Text;
            itens_carrinho.MétodoCarrinho(nome, tamanho, preço);
            itens_carrinho.AtualizarLabelComContagem(numero_itens);
        }

        private void WBbtn8_Click(object sender, EventArgs e)
        {
            string nome = "sweat vermelha mulher";
            //string tamanho = checkedListBox1.CheckedItems[0].ToString();
            string tamanho = "M";
            string preço = label1.Text;
            itens_carrinho.MétodoCarrinho(nome, tamanho, preço);
            itens_carrinho.AtualizarLabelComContagem(numero_itens);
        }
    }
}
