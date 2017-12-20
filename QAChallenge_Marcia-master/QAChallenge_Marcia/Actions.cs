using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using QAChallenge_Marcia.Pages;
using System;

namespace QAChallenge_Marcia
{
    class Actions
    {
        public static void InitializeDriver()
        {
            Driver.driver = new ChromeDriver();
            Driver.driver.Navigate().GoToUrl(Config.BaseURL);
        }
        public static bool IsElementPresent(By by)
        {
            try
            {
                Driver.driver.FindElement(by);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static void TakeScreenShotOnFailure(string filename)
        {

            if (!TestContext.CurrentContext.Result.Outcome.Status.Equals(ResultState.Success))
            {

                Screenshot scrnShot = ((ITakesScreenshot)Driver.driver).GetScreenshot();
                scrnShot.SaveAsFile(Config.filePath + filename, ScreenshotImageFormat.Png);

            }

        }

        public static void FillForm()
        {
            HomePage homePage = new HomePage();
            homePage.LoginPage.Click();
        }
        public static void CreateNewAccount()
        {
            TimeSpan ts = TimeSpan.FromSeconds(20);
            WebDriverWait wait = new WebDriverWait(Driver.driver, ts);

            LoginPage loginPage = new LoginPage();
            loginPage.CreateAccount.SendKeys(Config.Credentials.AccessName);           
            loginPage.BtnCreateAccount.Click();

            AccountCreation registration = new AccountCreation();
            wait.Until(ExpectedConditions.ElementExists(By.ClassName("account_creation")));
            registration.BtnGenderMrs.Click();
            registration.FirstName.SendKeys(Config.ValuesRegistration.FirstName);
            registration.LastName.SendKeys(Config.ValuesRegistration.LastName);
            registration.Password.SendKeys(Config.ValuesRegistration.Password);
            registration.BirthDay.Click();
            registration.BirthMonth.Click();
            registration.BirthYear.Click();
            registration.SignUpNewsLetter.Click();
            registration.ReceiveOffers.Click();
            registration.StreetAdress.SendKeys(Config.ValuesRegistration.StreetAdress);
            registration.City.SendKeys(Config.ValuesRegistration.City);
            registration.State.Click();
            registration.ZipCode.SendKeys(Config.ValuesRegistration.ZipCode);
            registration.Country.Click();
            registration.MobileNumber.SendKeys(Config.ValuesRegistration.MobileNumer);
            registration.BtnRegister.Click();
        }

        public static void ValidLogin()
        {
            TimeSpan ts = TimeSpan.FromSeconds(20);
            WebDriverWait wait = new WebDriverWait(Driver.driver, ts);

            LoginPage loginPage = new LoginPage();
            wait.Until(ExpectedConditions.ElementExists(By.ClassName("page-subheading")));
            loginPage.Login.SendKeys(Config.Credentials.AccessName);
            loginPage.Password.SendKeys(Config.Credentials.Password);
            loginPage.BtnSignIn.Click();
            wait.Until(ExpectedConditions.ElementExists(By.CssSelector("#center_column > div > div:nth-child(1) > ul > li:nth-child(4) > a")));
        }

    }
}
