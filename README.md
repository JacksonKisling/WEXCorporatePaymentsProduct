# WEX Purchase Transaction App

A .NET 8 Windows Forms application that retrieves foreign exchange rate data from the U.S. Treasury Fiscal Data API.

## Features
- Fetches real-time currency exchange rates
- Displays results in a Windows Forms UI
- Includes unit tests written with NUnit and Moq
- Uses dependency injection for HttpClient in testable design

## Project Structure
- **WEXCorporatePaymentsProduct** – Main Windows Forms app
- **WEX_Tests** – NUnit test project

## Requirements
- .NET 8 SDK
- Visual Studio 2022 or later

## Running the App
1. Open `WEXCorporatePaymentsProduct.sln` in Visual Studio.
2. Set `WEXCorporatePaymentsProduct` as the startup project.
3. Run the application.

## Running Unit Tests
- Open the Test Explorer in Visual Studio.
- Click “Run All Tests”.

---

© 2025 Jackson Kisling