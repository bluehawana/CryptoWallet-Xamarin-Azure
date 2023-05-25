# Crypto Wallet Xamarin

## Overview
Crypto Wallet Xamarin is a full-stack mobile application that allows users to track and monitor the prices of cryptocurrencies in real-time. The app utilizes Xamarin for front-end app development, .NET Function app for fetching 100 coins data from Coingecko every 2 minutes, and Azure Cosmos DB for storing the data. Azure SignalR is used to send information about data updates from Cosmos DB to the .NET Function.

The project was developed using Visual Studio Code for Mac and Visual Studio 2022 for Mac, making it easy to build and test the app on iOS and Android devices.

## Features
- Display a list of 100 cryptocurrencies with their current prices and market data.
- Fetch the latest coin data from Coingecko every 2 minutes using a .NET Function app.
- Store the fetched data in Azure Cosmos DB for persistent storage.
- Receive real-time updates about data changes using Azure SignalR.

## Technologies Used
- Xamarin: Cross-platform mobile app development framework.
- .NET Function app: Serverless compute service for running backend code.
- Azure Cosmos DB: Globally distributed, multi-model database service.
- Azure SignalR: Real-time messaging and communication service.

## Getting Started
To run the Crypto Wallet Xamarin app and set up the backend components, follow these steps:

1. Clone the repository to your local machine.
2. Open the project in Visual Studio Code for Mac or Visual Studio 2022 for Mac.
3. Set up the Azure resources:
   - Create an Azure Cosmos DB account and obtain the connection string.
   - Create an Azure Function app and configure it to access the Cosmos DB account.
   - Set up Azure SignalR service and get the connection string.
4. Update the configuration:
   - In the Xamarin app, update the `appsettings.json` file with the Cosmos DB and SignalR connection strings.
   - In the Function app, update the `local.settings.json` file with the Cosmos DB connection string.
5. Build and deploy the Function app to Azure.
6. Build and run the Xamarin app on an iOS or Android emulator or device.
7. Use the app to track cryptocurrency prices, and observe real-time updates when the data changes.

## Contributors
- [Your Name](https://github.com/yourusername)

## License
This project is licensed under the [MIT License](LICENSE).

Feel free to contribute to the project by submitting pull requests or creating issues in the repository.

## Acknowledgements
- Coingecko API: Data source for cryptocurrency prices and market data.
- Azure Documentation: Resources and guides for Azure services.

## Conclusion
Crypto Wallet Xamarin demonstrates the power of Xamarin for building cross-platform mobile apps and integrating them with Azure services. By leveraging Xamarin's rich UI capabilities and Azure's scalable backend services, you can create feature-rich mobile applications with real-time data updates.

Enjoy tracking your favorite cryptocurrencies with Crypto Wallet Xamarin!
