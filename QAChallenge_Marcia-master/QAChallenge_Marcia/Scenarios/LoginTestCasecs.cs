using NUnit.Framework;
using System.Threading;

namespace QAChallenge_Marcia.Scenarios
{
    class LoginTestCasecs
    {
        public LoginTestCasecs()
        {

        }

        [OneTimeSetUp]
        public void InitializeDriver()
        {
            Actions.InitializeDriver();
        }

        [Test]
        public void ValidLogin()
        {
            Actions.FillForm();
            Thread.Sleep(1000);
            Actions.ValidLogin();
            Thread.Sleep(1000);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            string fileName = "ValidLogin.jpg";
            Actions.TakeScreenShotOnFailure(fileName);
            Driver.driver.Quit();
        }
    }
}
