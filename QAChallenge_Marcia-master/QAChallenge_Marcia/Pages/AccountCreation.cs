using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace QAChallenge_Marcia.Pages
{
    class AccountCreation
    {
        public AccountCreation()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.Id, Using = "id_gender1")]
        public IWebElement BtnGenderMr { get; set; }

        [FindsBy(How = How.Id, Using = "id_gender2")]
        public IWebElement BtnGenderMrs { get; set; }

        [FindsBy(How = How.Id, Using = "customer_firstname")]
        public IWebElement FirstName { get; set; }

        [FindsBy(How = How.Id, Using = "customer_lastname")]
        public IWebElement LastName { get; set; }

        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement Email { get; set; }

        [FindsBy(How = How.Id, Using = "passwd")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#days > option:nth-child(21)")]
        public IWebElement BirthDay { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#months > option:nth-child(7)")]
        public IWebElement BirthMonth { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#years > option:nth-child(20)")]
        public IWebElement BirthYear { get; set; }
            
        [FindsBy(How = How.Id, Using = "newsletter")]
        public IWebElement SignUpNewsLetter { get; set; }

        [FindsBy(How = How.Id, Using = "optin")]
        public IWebElement ReceiveOffers { get; set; }

        [FindsBy(How = How.Id, Using = "address1")]
        public IWebElement StreetAdress { get; set; }

        [FindsBy(How = How.Id, Using = "address2")]
        public IWebElement UnitAdress { get; set; }
        
        [FindsBy(How = How.Id, Using = "city")]
        public IWebElement City{ get; set; }
         
        [FindsBy(How = How.CssSelector, Using = "#id_state > option:nth-child(7)")]
        public IWebElement State { get; set; }

        [FindsBy(How = How.Id, Using = "postcode")]
        public IWebElement ZipCode{ get; set; }

        [FindsBy(How = How.CssSelector, Using = "#id_country > option:nth-child(2)")]
        public IWebElement Country { get; set; }
        
        [FindsBy(How = How.Id, Using = "phone_mobile")]
        public IWebElement MobileNumber{ get; set; }

        [FindsBy(How = How.Id, Using = "alias")]
        public IWebElement Reference{ get; set; }

        [FindsBy(How = How.Id, Using = "submitAccount")]
        public IWebElement BtnRegister{ get; set; }

    }
}
