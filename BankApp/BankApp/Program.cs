class Program
{
    static void Main()
    {
        Console.WriteLine("Bank");
        Console.WriteLine("Login Page");

        string userName = null, password = null;

        Console.Write("Username: ");
        userName = Console.ReadLine();

        if (userName != null || userName != "")
        {

            Console.Write("Password: ");
            password = Console.ReadLine();
        }

        if (userName == "771" && password == "123")
        {
            int mainMenuChoice = -1;

            do
            {

                Console.WriteLine("Main Menu");
                Console.WriteLine("1. Customers");
                Console.WriteLine("2. Accounts");
                Console.WriteLine("3. Funds Transfer");
                Console.WriteLine("4. Funds Transfer Statement");
                Console.WriteLine("5. Account Statement");
                Console.WriteLine("0. Exit");

                Console.Write("Enter number: ");
                mainMenuChoice = int.Parse(Console.ReadLine());

                switch (mainMenuChoice)
                {
                    case 0:
                        break;
                    case 1:
                        CustomersMenu();
                        break;
                    case 2:
                        AccountsMenu();
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    default:
                        break;
                }
            } while (mainMenuChoice != 0);

        }

        else
        {
            Console.WriteLine("Something went wrong");
        }

        Console.WriteLine("Thank you");
        Console.ReadKey();
    }

    static void CustomersMenu()
    {
        int customerMenuChoice = -1;

        do
        {
            Console.WriteLine("Customers Menu");
            Console.WriteLine("1. Add Customer");
            Console.WriteLine("2. Delete Customer");
            Console.WriteLine("3. Update Customer");
            Console.WriteLine("4. View Customers");
            Console.WriteLine("0. Back to Main");
            Console.WriteLine("Enter Choice: ");
            customerMenuChoice = Convert.ToInt32(Console.ReadLine());

        } while (customerMenuChoice != 0);
    }

    static void AccountsMenu()
    {
        int accountsMenuChoice = -1;

        do
        {
            Console.WriteLine("Accounts Menu");
            Console.WriteLine("1. Add Account");
            Console.WriteLine("2. Delete Account");
            Console.WriteLine("3. Update Account");
            Console.WriteLine("4. View Account");
            Console.WriteLine("0. Back to Main");

            Console.WriteLine("Enter Choice: ");
            accountsMenuChoice = Convert.ToInt32(Console.ReadLine());

        } while (accountsMenuChoice != 0);
    }
}