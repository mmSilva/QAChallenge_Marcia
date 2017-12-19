namespace QAChallenge_Marcia
{
    class Config
    {
        public static string BaseURL = "http://automationpractice.com/index.php";
        public static string filePath = @"C:\Users\mmSil\Pictures\Screenshots\"; // Select the folder where you wish save the screenshots

        public class Credentials
        {
            public static string AccessName = "mm.silva@outlook.com.br";
            public static string Password = "teste12@";
        }
        public class ValuesRegistration
        {
            public static string Email = "mm.silva@outlook.com.br";
            public static string FirstName = "Maria";
            public static string LastName = "Silva";
            public static string Password = "teste12@";
            public static string StreetAdress = "Cascade";
            public static string City = "Denver";
            public static string ZipCode = "80260";
            public static string MobileNumer = "415 555 2671";
            public static string Reference = "To turn right on Walmart";
        }
    }

}
