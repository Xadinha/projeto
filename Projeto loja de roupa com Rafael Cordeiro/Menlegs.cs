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
            if (radioButton3.Checked == false && radioButton4.Checked == false)
            { MessageBox.Show("Tem de escolher um tamanho"); }
            else
            {
                if (radioButton3.Checked == true && radioButton4.Checked == false)
                {
                    string nome = "calças super baggy cinzas homem";
                    string tamanho = radioButton3.Text;
                    string preço = label1.Text;
                    itens_carrinho.MétodoCarrinho(nome, tamanho, preço);
                    itens_carrinho.AtualizarLabelComContagem(numero_itens);
                }
                else
                {
                    if (radioButton3.Checked == false && radioButton4.Checked == true)
                    {
                        string nome = "calças super baggy cinzas homem";
                        string tamanho = radioButton4.Text;
                        string preço = label1.Text;
                        itens_carrinho.MétodoCarrinho(nome, tamanho, preço);
                        itens_carrinho.AtualizarLabelComContagem(numero_itens);
                    }
                }
            }
        }
        private void MLbtn3_Click(object sender, EventArgs e)
        {
            if (radioButton5.Checked == false && radioButton6.Checked == false)
            { MessageBox.Show("Tem de escolher um tamanho"); }
            else
            {
                if (radioButton5.Checked == true && radioButton6.Checked == false)
                {
                    string nome = "calças super baggy azul claro homem";
                    string tamanho = radioButton5.Text;
                    string preço = label1.Text;
                    itens_carrinho.MétodoCarrinho(nome, tamanho, preço);
                    itens_carrinho.AtualizarLabelComContagem(numero_itens);
                }
                else
                {
                    if (radioButton5.Checked == false && radioButton6.Checked == true)
                    {
                        string nome = "calças super baggy azul claro homem";
                        string tamanho = radioButton6.Text;
                        string preço = label1.Text;
                        itens_carrinho.MétodoCarrinho(nome, tamanho, preço);
                        itens_carrinho.AtualizarLabelComContagem(numero_itens);
                    }
                }
            }
        }
        private void MLbtn4_Click(object sender, EventArgs e)
        {
            if (radioButton7.Checked == false && radioButton8.Checked == false)
            { MessageBox.Show("Tem de escolher um tamanho"); }
            else
            {
                if (radioButton7.Checked == true && radioButton8.Checked == false)
                {
                    string nome = "calças super baggy azul claro homem";
                    string tamanho = radioButton7.Text;
                    string preço = label1.Text;
                    itens_carrinho.MétodoCarrinho(nome, tamanho, preço);
                    itens_carrinho.AtualizarLabelComContagem(numero_itens);
                }
                else
                {
                    if (radioButton7.Checked == false && radioButton8.Checked == true)
                    {
                        string nome = "calças super baggy azul claro homem";
                        string tamanho = radioButton8.Text;
                        string preço = label1.Text;
                        itens_carrinho.MétodoCarrinho(nome, tamanho, preço);
                        itens_carrinho.AtualizarLabelComContagem(numero_itens);
                    }
                }
            }
        }
        private void MLbtn5_Click_1(object sender, EventArgs e)
        {
            if (radioButton9.Checked == false && radioButton10.Checked == false)
            { MessageBox.Show("Tem de escolher um tamanho"); }
            else
            {
                if (radioButton9.Checked == true && radioButton10.Checked == false)
                {
                    string nome = "calças skater pretas homem";
                    string tamanho = radioButton7.Text;
                    string preço = label1.Text;
                    itens_carrinho.MétodoCarrinho(nome, tamanho, preço);
                    itens_carrinho.AtualizarLabelComContagem(numero_itens);
                }
                else
                {
                    if (radioButton9.Checked == false && radioButton10.Checked == true)
                    {
                        string nome = "calças skater pretas homem";
                        string tamanho = radioButton8.Text;
                        string preço = label1.Text;
                        itens_carrinho.MétodoCarrinho(nome, tamanho, preço);
                        itens_carrinho.AtualizarLabelComContagem(numero_itens);
                    }
                }
            }
        }

        private void MLbtn6_Click_1(object sender, EventArgs e)
        {
            if (radioButton11.Checked == false && radioButton12.Checked == false)
            { MessageBox.Show("Tem de escolher um tamanho"); }
            else
            {
                if (radioButton11.Checked == true && radioButton12.Checked == false)
                {
                    string nome = "calças skater pretas homem";
                    string tamanho = radioButton7.Text;
                    string preço = label1.Text;
                    itens_carrinho.MétodoCarrinho(nome, tamanho, preço);
                    itens_carrinho.AtualizarLabelComContagem(numero_itens);
                }
                else
                {
                    if (radioButton11.Checked == false && radioButton12.Checked == true)
                    {
                        string nome = "calças skater pretas homem";
                        string tamanho = radioButton8.Text;
                        string preço = label1.Text;
                        itens_carrinho.MétodoCarrinho(nome, tamanho, preço);
                        itens_carrinho.AtualizarLabelComContagem(numero_itens);
                    }
                }
            }
        }

        private void MLbtn7_Click_1(object sender, EventArgs e)
        {
            if (radioButton13.Checked == false && radioButton14.Checked == false)
            { MessageBox.Show("Tem de escolher um tamanho"); }
            else
            {
                if (radioButton13.Checked == true && radioButton14.Checked == false)
                {
                    string nome = "calças skater azul claro homem";
                    string tamanho = radioButton7.Text;
                    string preço = label1.Text;
                    itens_carrinho.MétodoCarrinho(nome, tamanho, preço);
                    itens_carrinho.AtualizarLabelComContagem(numero_itens);
                }
                else
                {
                    if (radioButton13.Checked == false && radioButton14.Checked == true)
                    {
                        string nome = "calças skater azul claro homem"; 
                        string tamanho = radioButton8.Text;
                        string preço = label1.Text;
                        itens_carrinho.MétodoCarrinho(nome, tamanho, preço);
                        itens_carrinho.AtualizarLabelComContagem(numero_itens);
                    }
                }
            }
        }

        private void MLbtn8_Click_1(object sender, EventArgs e)
        {
            if (radioButton15.Checked == false && radioButton16.Checked == false)
            { MessageBox.Show("Tem de escolher um tamanho"); }
            else
            {
                if (radioButton15.Checked == true && radioButton16.Checked == false)
                {
                    string nome = "calças skater castanhas homem";
                    string tamanho = radioButton7.Text;
                    string preço = label1.Text;
                    itens_carrinho.MétodoCarrinho(nome, tamanho, preço);
                    itens_carrinho.AtualizarLabelComContagem(numero_itens);
                }
                else
                {
                    if (radioButton15.Checked == false && radioButton16.Checked == true)
                    {
                        string nome = "calças skater azul claro homem"; ;
                        string tamanho = radioButton8.Text;
                        string preço = label1.Text;
                        itens_carrinho.MétodoCarrinho(nome, tamanho, preço);
                        itens_carrinho.AtualizarLabelComContagem(numero_itens);
                    }
                }
            }
        }
    }
}
