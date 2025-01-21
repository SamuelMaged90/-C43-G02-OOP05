using System.Net.Security;
using Task.Question02;
using Task.Question03;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01

            //Circle circle  = new Circle();
            //circle.Radius = 10;
            //circle.DisplayShapeInfo();

            //Rectangle rectangle = new Rectangle();
            //rectangle.Width = 10;
            //rectangle.Length = 25;
            //rectangle.DisplayShapeInfo();

            #endregion

            #region Question02
            //IAuthenticationService authService = new BasicAuthenticationService("Sasa","123","Admin");
            //Console.WriteLine(authService.AuthenticateUser("Sasaa","125"));
            //Console.WriteLine(authService.AuthorizeUser("Sasa","Admin")); 
            #endregion

            #region Question03
            INotificationService Email = new EmailNotificationService();
            Email.SendNotification("ABC", "Hello Email");
            INotificationService SMS = new SmsNotificationService();
            SMS.SendNotification("DEF", "Hello SMS");
            INotificationService service = new PushNotificationService();
            service.SendNotification("GHI", "Hello service");
            #endregion
        }
    }
}
