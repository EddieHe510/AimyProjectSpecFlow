using AimyOneLoginTest.Drivers;
using OpenQA.Selenium;

namespace AimyOneLoginTest.Components.LoginPageComponent
{
    public class Login : Hook
    {
        private IWebElement loginUsername => driver.FindElement(By.Id("Username"));
        private IWebElement loginPassword => driver.FindElement(By.Id("Password"));
        private IWebElement rememberMeCheckBox => driver.FindElement(By.Id("RememberLogin"));
        private IWebElement loginButton => driver.FindElement(By.XPath("//button[@class=\"btn btn-lg btn-primary btn-block submit-button custom-btn-login\"]"));
        private IWebElement registerButton => driver.FindElement(By.XPath("//button[@value=\"register\"]"));
        private IWebElement forgotPasswordButton => driver.FindElement(By.XPath("//button[@value=\"forgot-password\"]"));

        private IWebElement actualUsername => driver.FindElement(By.XPath("//*[contains(text(),'hlhedison@gmail.com')]"));
        private IWebElement errorMessage => driver.FindElement(By.XPath("//li"));


        public void loginWithCredentails(string username, string password)
        {
            loginUsername.SendKeys(username);
            loginPassword.SendKeys(password);
            rememberMeCheckBox.Click();
            loginButton.Click();
        }

        public string assertUsername()
        {
            // Fluent wait for the "actualUsername" element
            Wait.WaitToBeVisible("XPath", 20, "//*[contains(text(),'hlhedison@gmail.com')]");

            return actualUsername.Text;
        }

        public string invalidCredentialsMessage()    
        {
            Wait.WaitToBeVisible("XPath", 10, "//li");
            return errorMessage.Text;
        }
    }
}
