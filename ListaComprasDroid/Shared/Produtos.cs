using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ListaComprasDroid.Shared
{
    public class Produtos
    {
        public string NomeProduto { get; set; }
        public int QuantidadeProduto { get; set; }

        public List<Produtos> listaProdutos;
        public Produtos(string nomeProduto, int qtdProduto)
        {
            NomeProduto = nomeProduto;
            QuantidadeProduto = qtdProduto;
        }
        public Produtos()
        {
            listaProdutos = new List<Produtos>();
        }

        public override string ToString()
        {
            return NomeProduto;
        }
    }
}