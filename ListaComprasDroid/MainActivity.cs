using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;
using Android.Content;

namespace ListaComprasDroid
{
    [Activity(Label = "ListaComprasDroid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        Button produtos;
        Button sobre;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            produtos = (Button)FindViewById(Resource.Id.btnProdutos);
            produtos.Click += (sender, e) => {
                StartActivity(typeof(ProdutosActivity));
            };

            sobre = (Button)FindViewById(Resource.Id.btnSobre);
            sobre.Click += (sender, e) => {
                StartActivity(typeof(ProdutosActivity));
            };
            
        }
    }
}

