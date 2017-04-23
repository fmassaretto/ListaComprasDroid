using System;
using Android.App;
using Android.OS;
using Android.Views;
using Android.Content;
using Android.Widget;
using System.Collections.Generic;
using ListaComprasDroid.Shared;
using Android.Runtime;

namespace ListaComprasDroid
{
    [Activity(Label = "Lista de Produtos")]
    public class ProdutosActivity : Activity
    {
        Produtos produtos;
        ListView lstViewProdutos;

        public static List<Produtos> Items = new List<Produtos>();
        protected override void OnCreate(Bundle savedInstanceState)
        {
            
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Produtos);
            // Create your application here
            
            lstViewProdutos = FindViewById<ListView>(Resource.Id.lstViewProdutos);

            produtos = new Produtos();
            

            
            var btnAdicionar = FindViewById<Button>(Resource.Id.btnAdicionarProduto);
            btnAdicionar.Click += (sender, e) =>
            {
                EditText nomeProduto = FindViewById<EditText>(Resource.Id.txtProduto);
                EditText qtdProduto = FindViewById<EditText>(Resource.Id.txtQuantidadeProduto);

                produtos.listaProdutos.Add(new Produtos()
                {
                    NomeProduto = nomeProduto.Text,
                    QuantidadeProduto = int.Parse(qtdProduto.Text)
                });

                //Items.Add(new Produtos
                //{
                //    NomeProduto = nomeProduto.Text,
                //    QuantidadeProduto = int.Parse(qtdProduto.Text)
                //});
                this.lstViewProdutos.Adapter = new ArrayAdapter<Produtos>(this, Android.Resource.Layout.SimpleListItem1, Android.Resource.Id.Text1, produtos.listaProdutos);

                //onCreateDialog(savedInstanceState);
            };

            lstViewProdutos.ItemClick += OnItemClick;
        }

        void OnItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var produto = produtos.listaProdutos[e.Position];
            string texto = "Produto: " + produto.NomeProduto + " Quantidade: " + produto.QuantidadeProduto;
            Toast.MakeText(this, texto, ToastLength.Long).Show();
        }

        public Dialog onCreateDialog(Bundle savedInstanceState)
        {
            AlertDialog.Builder builder = new AlertDialog.Builder(this);
            var dialogView = LayoutInflater.Inflate(Resource.Layout.AdicionarProdutoDialog, null);
            builder.SetView(dialogView);
            builder.SetTitle(Resource.String.AdicionarProdutos);

            builder.SetPositiveButton("OK", (sender, e) =>
            {
                Dialog d = new Dialog(this);

                EditText nomeProduto = this.FindViewById<EditText>(Resource.Id.txtProduto);
                EditText qtdProduto = this.FindViewById<EditText>(Resource.Id.txtQuantidadeProduto);

                Items.Add(new Produtos
                {
                    NomeProduto = nomeProduto.Text,
                    QuantidadeProduto = int.Parse(qtdProduto.Text)
                });
                this.lstViewProdutos.Adapter = new ArrayAdapter<Produtos>(this, Android.Resource.Layout.SimpleListItem1, Android.Resource.Id.Text1, Items);

                //var intent = new Intent(this, typeof(ProdutosActivity));
                //intent.PutExtra("NomeProd", nomeProduto);
                //intent.PutExtra("qtdProd", qtdProduto);

                //StartActivity(intent);

                //Produtos produtos = new Produtos(nomeProduto, qtdProduto);



                Toast.MakeText(this, "Produto adicionado com sucesso!", ToastLength.Short).Show();
            });

            return builder.Show();

        }
    }

}
