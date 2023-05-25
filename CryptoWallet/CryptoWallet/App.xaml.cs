using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CryptoWallet
{
    public partial class App : Application
    {
        public App ()
        {
            InitializeComponent();

            MainPage = new MainPage();

            Preferences.Set("CosmosDBConnection", "AccountEndpoint=https://coins.documents.azure.com:443/;AccountKey=8RV426RZa8tqF0O6qqxdT3e0fM04KkDXCN3G850bJ9Kyhqm82XRXOtcXEQv6yeloZ8u0hraiugnQACDbuOvqmw==");
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}

