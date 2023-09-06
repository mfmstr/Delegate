using System;
using System.IO;

namespace Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account(500);
            // Delegate for console printing
            account1.setNotificationDelegate(message => Console.WriteLine(message));
            // Delegate for writing in file
            account1.setNotificationDelegate(message =>
            {
                string path = @"C:\Users\User\Desktop\Delegate\Log.txt";
                File.AppendAllText(path, message + Environment.NewLine);
            });

            account1.fillBalance(3000);
            account1.withdrow(100);
        }
    }
}
