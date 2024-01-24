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
            if (radioButton1.Checked == false && radioButton2.Checked == false)
            { MessageBox.Show("Tem de escolher um tamanho"); }
            else
            {
                if (radioButton1.Checked == true && radioButton2.Checked == false)
                {
                    string nome = "calças super baggy pretas homem";
                    string tamanho = radioButton1.Text;
                    string preço = label1.Text;
                    itens_carrinho.MétodoCarrinho(nome, tamanho, preço);
                    itens_carrinho.AtualizarLabelComContagem(numero_itens);
                }
                else
                {
                    if (radioButton1.Checked == false && radioButton2.Checked == true)
                    {
                        string nome = "calças super baggy pretas homem";
                        string tamanho = radioButton2.Text;
                        string preço = label1.Text;
                        itens_carrinho.MétodoCarrinho(nome, tamanho, preço);
                        itens_carrinho.AtualizarLabelComContagem(numero_itens);
                    }
                }
            }           
        }
        private void MLbtn2_Click(object sender, EventArgs e)
        {
            string nome = "calças super baggy cinzas homem";
            //string tamanho = checkML2.CheckedItems[0].ToString();
            string tamanho = "M";
            string preço = label1.Text;
            itens_carrinho.MétodoCarrinho(nome, tamanho, preço);
            itens_carrinho.AtualizarLabelComContagem(numero_itens);
        }
        private void MLbtn3_Click(object sender, EventArgs e)
        {
            string nome = "calças super baggy azul claro homem";
            //string tamanho = checkML3.CheckedItems[0].ToString();
            string tamanho = "M";
            string preço = label1.Text;
            itens_carrinho.MétodoCarrinho(nome, tamanho, preço);
            itens_carrinho.AtualizarLabelComContagem(numero_itens);
        }
        private void MLbtn4_Click(object sender, EventArgs e)
        {
            string nome = "calças super baggy azul escuro homem";
            //string tamanho = checkML4.CheckedItems[0].ToString();
            string tamanho = "M";
            string preço = label1.Text;
            itens_carrinho.MétodoCarrinho(nome, tamanho, preço);
            itens_carrinho.AtualizarLabelComContagem(numero_itens);
        }
        private void MLbtn5_Click(object sender, EventArgs e)
        {
            string nome = "calças skater pretas homem";
            //string tamanho = checkML5.CheckedItems[0].ToString();
            string tamanho = "M";
            string preço = label1.Text;
            itens_carrinho.MétodoCarrinho(nome, tamanho, preço);
            itens_carrinho.AtualizarLabelComContagem(numero_itens);
        }
        private void MLbtn6_Click(object sender, EventArgs e)
        {
            string nome = "calças skater azul escuro homem";
            //string tamanho = checkML6.CheckedItems[0].ToString();
            string tamanho = "M";
            string preço = label1.Text;
            itens_carrinho.MétodoCarrinho(nome, tamanho, preço);
            itens_carrinho.AtualizarLabelComContagem(numero_itens);
        }
        private void MLbtn7_Click(object sender, EventArgs e)
        {
            string nome = "calças skater azul claro homem";
            //string tamanho = checkML7.CheckedItems[0].ToString();
            string tamanho = "M";
            string preço = label1.Text;
            itens_carrinho.MétodoCarrinho(nome, tamanho, preço);
            itens_carrinho.AtualizarLabelComContagem(numero_itens);
        }
        private void MLbtn8_Click(object sender, EventArgs e)
        {
            string nome = "calças skater castanhas homem";
            //string tamanho = checkML8.CheckedItems[0].ToString();
            string tamanho = "M";
            string preço = label1.Text;
            itens_carrinho.MétodoCarrinho(nome, tamanho, preço);
            itens_carrinho.AtualizarLabelComContagem(numero_itens);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
