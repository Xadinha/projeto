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
    public partial class MenBody : Form
    {
        public MenBody()
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
        private void bttn_carrinho_Click(object sender, EventArgs e)
        {
            carrinho pagar = new carrinho();
            this.Hide();
            pagar.Show();
        }

        private void MBbtn1_Click(object sender, EventArgs e)
        {
            string nome = "sweat spyder azul homem";
            //string tamanho = checkedListBox1.CheckedItems[0].ToString();
            string tamanho = "M";
            string preço = label1.Text;
            itens_carrinho.MétodoCarrinho(nome, tamanho, preço);
            itens_carrinho.AtualizarLabelComContagem(numero_itens);
        }

        private void MBbtn2_Click(object sender, EventArgs e)
        {
            string nome = "sweat spyder preta homem";
            //string tamanho = checkedListBox1.CheckedItems[0].ToString();
            string tamanho = "M";
            string preço = label1.Text;
            itens_carrinho.MétodoCarrinho(nome, tamanho, preço);
            itens_carrinho.AtualizarLabelComContagem(numero_itens);
        }

        private void MBbtn3_Click(object sender, EventArgs e)
        {
            string nome = "sweat sem capuz preta homem";
            //string tamanho = checkedListBox1.CheckedItems[0].ToString();
            string tamanho = "M";
            string preço = label1.Text;
            itens_carrinho.MétodoCarrinho(nome, tamanho, preço);
            itens_carrinho.AtualizarLabelComContagem(numero_itens);
        }

        private void MBbtn4_Click(object sender, EventArgs e)
        {
            string nome = "sweat com capuz azul escuro homem";
            //string tamanho = checkedListBox1.CheckedItems[0].ToString();
            string tamanho = "M";
            string preço = label1.Text;
            itens_carrinho.MétodoCarrinho(nome, tamanho, preço);
            itens_carrinho.AtualizarLabelComContagem(numero_itens);
        }

        private void MBbtn5_Click(object sender, EventArgs e)
        {
            string nome = "sweat com capuz azul claro homem";
            //string tamanho = checkedListBox1.CheckedItems[0].ToString();
            string tamanho = "M";
            string preço = label1.Text;
            itens_carrinho.MétodoCarrinho(nome, tamanho, preço);
            itens_carrinho.AtualizarLabelComContagem(numero_itens);
        }

        private void MBbtn6_Click(object sender, EventArgs e)
        {
            string nome = "sweat com capuz rosa homem";
            //string tamanho = checkedListBox1.CheckedItems[0].ToString();
            string tamanho = "M";
            string preço = label1.Text;
            itens_carrinho.MétodoCarrinho(nome, tamanho, preço);
            itens_carrinho.AtualizarLabelComContagem(numero_itens);
        }

        private void MBbtn7_Click(object sender, EventArgs e)
        {
            string nome = "sweat sem capuz creme baggy homem";
            //string tamanho = checkedListBox1.CheckedItems[0].ToString();
            string tamanho = "M";
            string preço = label1.Text;
            itens_carrinho.MétodoCarrinho(nome, tamanho, preço);
            itens_carrinho.AtualizarLabelComContagem(numero_itens);
        }

        private void MBbtn8_Click(object sender, EventArgs e)
        {
            string nome = "sweat sem capuz creme homem";
            //string tamanho = checkedListBox1.CheckedItems[0].ToString();
            string tamanho = "M";
            string preço = label1.Text;
            itens_carrinho.MétodoCarrinho(nome, tamanho, preço);
            itens_carrinho.AtualizarLabelComContagem(numero_itens);
        }

        private void bttn_anterior_Click(object sender, EventArgs e)
        {
            Men men = new Men();
            this.Hide();
            men.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
