using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Microsoft.Azure.Documents.Linq;

namespace CryptoWallet
{
    public partial class MainPage : ContentPage
    {
        private DocumentClient client;

        public MainPage()
        {
            InitializeComponent();

            InitializeDocumentClient();

            FetchCoins_Clicked(null, null);
        }

        private void InitializeDocumentClient()
        {
            string accountUrl = AppConfig.accountUrl;
            string accountKey = AppConfig.accountKey;
            string databaseId = AppConfig.databaseId;
            string collectionId = AppConfig.collectionId;

            // Use the sensitive information as needed to initialize the DocumentClient
            client = new DocumentClient(new Uri(accountUrl), accountKey);
        }

        private async void FetchCoins_Clicked(object sender, EventArgs e)
        {
            try
            {
                Uri collectionUri = UriFactory.CreateDocumentCollectionUri(AppConfig.databaseId, AppConfig.collectionId);

                // Create a LINQ query to retrieve the data with the filter
                var query = client.CreateDocumentQuery<Crypto>(collectionUri)
             .Where(c => c.current_price > 0)
             .OrderBy(c => c.market_cap_rank)
             .Take(100);

                var cryptos = query.ToList();
                // Set the ListView's ItemsSource to the retrieved data
                CryptoListView.ItemsSource = cryptos;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", "Could not fetch crypto data. " + ex.Message, "OK");
            }
        }

        private void CryptoListView_ItemTapped_Handler(object sender, ItemTappedEventArgs e)
        {
            // Handle the ListView's ItemTapped event
            if (e.Item is Crypto tappedCrypto)
            {
                string message = $"Tapped crypto Name: {tappedCrypto.symbol}\n" +
                                 $"Current Price: {tappedCrypto.current_price}";

                DisplayAlert("Crypto Details", message, "OK");
            }
        }


    }
}
