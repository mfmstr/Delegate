namespace Delegate
{
    delegate void NotificationDelegate(string message);
    class Account
    {

        NotificationDelegate notificationDelegate;

        public decimal Balance;

        public void setNotificationDelegate(NotificationDelegate notificationDelegate)
        {
            this.notificationDelegate += notificationDelegate;
        }

        public Account(decimal balance)
        {
            this.Balance = balance;
        }
        public void fillBalance(decimal balance)
        {
            this.Balance += balance;
            if (notificationDelegate != null)
            {
                notificationDelegate($"Your balance is increased by {balance} GEL. Current balance is: {this.Balance}");
            }
        }
        public void withdrow(decimal balance)
        {
            if (this.Balance >= balance)
            {
                this.Balance -= balance;
                if (notificationDelegate != null)
                {
                    notificationDelegate($"Withdrown {balance} GEL from your account. Current balance is: {this.Balance}");
                }
            }
            else
            {
                if (notificationDelegate != null)
                {
                    notificationDelegate("Not enough balance");
                }
            }
        }
    }
}
