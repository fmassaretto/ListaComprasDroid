using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;
using Android.Content;

namespace ListaComprasDroid
{
    [Activity(Label = "@string/ApplicationName", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var produtos = FindViewById<Button>(Resource.Id.btnProdutos);
            produtos.Click += (sender, e) => {
                StartActivity(typeof(ProdutosActivity));
            };

            var sobre = FindViewById<Button>(Resource.Id.btnSobre);
            sobre.Click += (sender, e) => {
                StartActivity(typeof(SobreActivity));
            };
            
        }
    }
}

