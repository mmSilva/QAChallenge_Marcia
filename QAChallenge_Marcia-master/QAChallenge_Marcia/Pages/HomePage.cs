using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace QAChallenge_Marcia.Pages
{
    class HomePage
    {
        public HomePage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }
        
        [FindsBy(How = How.ClassName, Using = "login")]
        public IWebElement LoginPage { get; set; }
    }
}
