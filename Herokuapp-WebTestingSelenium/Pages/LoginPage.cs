using OpenQA.Selenium;

namespace Herokuapp_WebTestingSelenium.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver _driver;

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement Username => _driver.FindElement(By.Id("username"));
        private IWebElement Password => _driver.FindElement(By.Id("password"));
        private IWebElement LoginButton => _driver.FindElement(By.CssSelector("button[type='submit']"));
        private IWebElement FlashMessage => _driver.FindElement(By.Id("flash"));

        public void Open()
        {
            _driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/login");
        }

        public void Login(string username, string password)
        {
            Username.Clear();
            Username.SendKeys(username);
            Password.Clear();
            Password.SendKeys(password);
            LoginButton.Click();
        }

        public string GetFlashMessage()
        {
            return FlashMessage.Text;
        }
    }
}