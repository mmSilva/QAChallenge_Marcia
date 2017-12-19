using NUnit.Framework;
using System.Threading;

namespace QAChallenge_Marcia.Scenarios
{
    class CreateAccountTest
    {
        public CreateAccountTest()
        {

        }

        [OneTimeSetUp]
        public void InitializeDriver()
        {
            Actions.InitializeDriver();
        }

        [Test]
        public void CreateNewAccount()
        {
            Actions.FillForm();
            Thread.Sleep(1000);
            Actions.CreateNewAccount();
            Thread.Sleep(1000);

        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
