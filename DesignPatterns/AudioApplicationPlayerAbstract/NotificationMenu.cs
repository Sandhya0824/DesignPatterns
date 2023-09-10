using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioApplicationPlayerAbstract
{
    public class NotificationMenu
    {
        public static int ChooseNotificationType()
        {
            int choiceNotification = 0;

            Console.WriteLine("Choose the Notification Type: ");
            Console.WriteLine();

            Console.WriteLine("1: SMS");
            Console.WriteLine("2: EMail");
            Console.WriteLine("3. WhatsApp");
            Console.WriteLine("4. Telegram");
            Console.WriteLine();

            choiceNotification = int.Parse(Console.ReadLine());
            Console.WriteLine();

            return choiceNotification;
        }
    }
}
