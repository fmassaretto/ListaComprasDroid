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

namespace ListaComprasDroid
{
    [Activity(Label = "Sobre...")]
    public class SobreActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Sobre);
            // Create your application here
            FindViewById<Button>(Resource.Id.btnSaibaMais).Click += OnSaibaMaisClick;
        }

        private void OnSaibaMaisClick(object sender, EventArgs e)
        {
            Intent intent = new Intent();
            intent.SetAction(Intent.ActionView);
            intent.SetData(Android.Net.Uri.Parse("https://geolocationfb.azurewebsites.net/"));

            StartActivity(intent);
        }
    }
}