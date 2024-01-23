using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_loja_de_roupa_com_Rafael_Cordeiro
{
    internal class itens_carrinho
    {
        public string Nome;
        public string Tamanho;
        public string Preço;
        public static List<itens_carrinho> listaitens = new List<itens_carrinho>();
        public itens_carrinho(string nome, string tamanho, string preço) // Os construtores são tipos especiais de métodos usados para criar e inicializar objetos
        {
            Nome = nome;
            Tamanho = tamanho;
            Preço = preço;
        }
        public static void MétodoCarrinho(string nome, string tamanho, string preço)
        {
            itens_carrinho novoutilizador = new itens_carrinho(nome, tamanho, preço);
            listaitens.Add(novoutilizador);
        }
        public static int ContarItensCarrinho()
        {
            return listaitens.Count;
        }

        public static void AtualizarLabelComContagem(Label label)
        {
            int numeroDeItens = ContarItensCarrinho();
            label.Text = $"Número de Itens: {numeroDeItens}";
        }
        public static double CalcularPrecoTotal()
        {
            double precoTotal = 0;
            foreach (var item in listaitens)
            {
                // Extrai apenas os dígitos da string de preço
                string valorNumerico = new string(item.Preço.Where(char.IsDigit).ToArray());

                // Converte para double
                if (double.TryParse(valorNumerico, out double precoItem))
                {
                    precoTotal += precoItem;
                }
            }
            return precoTotal;
        }

        public static void AtualizarLabelComPrecoTotal(Label label)
        {
            double precoTotal = CalcularPrecoTotal();
            label.Text = $"Preço Total: {precoTotal:C2}";
        }
    }
}
    