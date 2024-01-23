using System;
using System.Collections.Generic;
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
        public static void MétodoCarrinho(string nome, string tamanho,string preço)
        {
            itens_carrinho novoutilizador = new itens_carrinho(nome,tamanho,preço);
            listaitens.Add(novoutilizador);
        }
    }
}
