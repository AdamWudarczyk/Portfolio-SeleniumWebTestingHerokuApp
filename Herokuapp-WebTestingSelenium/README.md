# Selenium POM – Herokuapp Web Testing

This is a test automation project using **Selenium WebDriver** in **C#** with **NUnit** and the **Page Object Model (POM)** pattern.  
It covers end-to-end UI testing of the demo application [The Internet by Herokuapp](https://the-internet.herokuapp.com/).

---

## Tech Stack

- C# (.NET 6.0)
- Selenium WebDriver
- ChromeDriver
- NUnit
- Page Object Model (POM)
- Git, GitHub

## Project Structure

Herokuapp-WebTestingSelenium/\
├── Drivers/ # Driver factory\
├── Pages/ # Page Object classes\
├── Utilities/ # Base test class\
├── Tests/ # Test files (NUnit)\
├── .gitignore\
├── README.md\
└── *.csproj\

## Test Scenarios

| Feature   | Scenario                              | Status |
|-----------|----------------------------------------|--------|
| Login     | Valid credentials                     | ✅      |
| Login     | Invalid credentials                   | ✅      |
| ...       | More to come...                       | 🔜      |

## Getting Started

### 1. Clone the repository

```bash
git clone https://github.com/AdamWudarczyk/Portfolio-SeleniumWebTestingHerokuApp.git
cd Portfolio-SeleniumWebTestingHerokuApp
```

### 2. Install dependencies
   Make sure you have .NET 6 SDK installed.

Then restore packages:

```bash
dotnet restore
```

### 3. Run tests

```bash
dotnet test
```

## How It Works
- The TestBase class sets up and tears down the browser session.
- The DriverFactory provides a ChromeDriver with options.
- Each page has its own class in the Pages folder following the POM pattern.
- Tests use these pages for clean and maintainable scenarios.

## To Do

TBD

___
Created by Adam Wudarczyk
