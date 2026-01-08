namespace ConsoleApp2
{

    /*
     * C# structure
     * - elements with scope ( namespace, class, method, loop(for, while), condition(if else, switch) )
     * example :
     * namespace ConsoleApp2 {  .... }
     * 
     * method : static void Main(string[] args) { .... } 
     *          static void Main(string[] args); { .... }  XXXX <- invalid
     *          
     * loop : for(int i=0; i<10; i++) { .... }
     *        for (int i=0; i<10; i++); { .... }  XXXX <- invalid
     *        
     *        while(condition) { .... }
     *        
     
       - elements without scope ( statement, expression )
     * example : input statement : Console.ReadLine();
     *           output statement : Console.WriteLine();
     *           operation expression : int sum = a + b;
     *           operation expression : bolean isValid = (a > b);
     */



    internal class Program
    {
        static void Main(string[] args)
        {

            //write your code here  
            //Bank system example: including ( create account, deposit money, withdraw money, check balance, transfer money )

            //Phase1: system storage
            string[] owners = new string[100]; //account owners
            string[] accounts = new string[100]; //100 accounts
            double[] balances = new double[100];      //account balances
            int LastAccountIndex = -1; // no account created yet

            //seed data
            owners[0] = "Alice";
            accounts[0] = "ACC0";
            balances[0] = 1000;
            LastAccountIndex++;

            owners[1] = "Bob";
            accounts[1] = "ACC1";
            balances[1] = 500;
            LastAccountIndex++;
             

            //permenant stroage : database, file system

            while (true)
            {
                Console.WriteLine("Welcome to the Bank System");
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Check Balance");
                Console.WriteLine("5. Transfer Money");
                Console.WriteLine("6. Exit");
                Console.Write("Please select an option: ");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        //Phase2: input &  //Phase3: processing
                        Console.Write("Enter your name: ");
                        owners[LastAccountIndex + 1] = Console.ReadLine();
                        Console.Write("Enter initial deposit amount: ");
                        balances[LastAccountIndex + 1] = double.Parse(Console.ReadLine());
                        accounts[LastAccountIndex + 1] = "ACC" + (LastAccountIndex + 1); //processing order

                        //Phase4: output
                        Console.WriteLine("Account created successfully!");
                        Console.WriteLine("Account Number: " + accounts[LastAccountIndex + 1]);

                        LastAccountIndex++;
                        break;


                    case 2:
                        break;



                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;

                    case 6:
                        break;

                    default:
                        break;
                }

                Console.WriteLine("Thank you for using the Bank System, press any key");
                Console.ReadLine();
                Console.Clear();


               
            }

       

        }

    }


}
// End of File














//        //withdraw money from ATM machine
//        //system storage
//        string storedAccountNumber = "Saving12053446";
//    int storedBalance = 5000;



//    // input phase
//    Console.WriteLine("Enter the amount to withdraw: ");
//    int amount = int.Parse(Console.ReadLine());

//    Console.WriteLine("enter account number: ");
//    string accountNumber = Console.ReadLine(); // Saving12053446      // 55 is number,  "55" is string



//    if (accountNumber == storedAccountNumber)
//    {

//        if(storedBalance >= amount)
//        {
//            Console.WriteLine("take your cash");
//            storedBalance -= amount;
//            //send sms
//        }
//        else 
//        {
//          Console.WriteLine("sorry Insufficient balance");
//        }

//    }
//    else
//    {
//        Console.WriteLine("Invalid account number");
//    }
//}



// int.parse()  method converts string to integer
// char ch = (char)Console.Read();





