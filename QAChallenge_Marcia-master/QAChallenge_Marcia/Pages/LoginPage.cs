using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace QAChallenge_Marcia.Pages
{
    class LoginPage
    {
        public LoginPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.Id, Using = "email_create")]
        public IWebElement CreateAccount { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#SubmitCreate > span")]
        public IWebElement BtnCreateAccount { get; set; }

        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement Login { get; set; }

        [FindsBy(How = How.Id, Using = "passwd")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "SubmitLogin")]
        public IWebElement BtnSignIn { get; set; }

    }
}
