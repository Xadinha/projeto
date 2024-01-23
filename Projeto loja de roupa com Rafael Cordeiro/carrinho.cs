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
    public partial class carrinho : Form
    {
        public carrinho()
        {
            InitializeComponent();
            foreach (itens_carrinho itens_carrinho in itens_carrinho.listaitens)
            {
                LBC.Items.Add($"{itens_carrinho.Nome} |{itens_carrinho.Tamanho} | {itens_carrinho.Preço}");

            }
            itens_carrinho.AtualizarLabelComPrecoTotal(label5);
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
        private void MPbtn_Click(object sender, EventArgs e)
        {
            if (nome_utilizador.nomeutilizador == "")
            { MessageBox.Show("Tem de fazer login"); }
            else
            {
                if (NCtxt.Text == "" || DVtxt.Text == "" || CVCtxt.Text == "" || MEtxt.Text == "")
                { MessageBox.Show("Tem de preencher todas as informações"); }
                else
                { MessageBox.Show("Obrigado por comprar na nossa loja"); }
            }
        }
        private void Limpar_bttn_Click(object sender, EventArgs e)
        {
            // Limpa a ListBox
            LBC.Items.Clear();

            // Limpa a lista de itens_carrinho
            itens_carrinho.listaitens.Clear();

            // Atualiza a Label com o preço total
            itens_carrinho.AtualizarLabelComPrecoTotal(label5);
        }
        private void Apagar_Click(object sender, EventArgs e)
        {
            // Verifica se há pelo menos um item na ListBox
            if (LBC.Items.Count > 0)
            {
                // Remove o último item da ListBox
                LBC.Items.RemoveAt(LBC.Items.Count - 1);

                // Remove o último item da lista de itens_carrinho
                if (itens_carrinho.listaitens.Count > 0)
                {
                    itens_carrinho.listaitens.RemoveAt(itens_carrinho.listaitens.Count - 1);
                }

                // Atualiza a Label com o preço total
                itens_carrinho.AtualizarLabelComPrecoTotal(label5);
            }
            else
            {
                MessageBox.Show("A ListBox está vazia. Não há itens para remover.");
            }
        }
    }
}
