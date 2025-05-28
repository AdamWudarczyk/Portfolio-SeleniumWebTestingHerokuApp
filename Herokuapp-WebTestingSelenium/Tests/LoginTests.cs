using NUnit.Framework;
using Herokuapp_WebTestingSelenium.Pages;
using Herokuapp_WebTestingSelenium.Utilities;

namespace Herokuapp_WebTestingSelenium.Tests
{
    [TestFixture]
    public class LoginTests : TestBase
    {
        [Test]
        public void LoginWithValidCredentials_ShouldSucceed()
        {
            var loginPage = new LoginPage(Driver);
            loginPage.Open();
            loginPage.Login("tomsmith", "SuperSecretPassword!");
            Assert.That(loginPage.GetFlashMessage(), Does.Contain("You logged into a secure area!"));
        }

        [Test]
        public void LoginWithInvalidCredentials_ShouldFail()
        {
            var loginPage = new LoginPage(Driver);
            loginPage.Open();
            loginPage.Login("invalid", "invalid");
            Assert.That(loginPage.GetFlashMessage(), Does.Contain("Your username is invalid!"));
        }
    }
}