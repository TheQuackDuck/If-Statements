namespace If_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance = 150;
            Console.WriteLine("Part 1 - Bank of Blorb:");
            Console.WriteLine("Welcome to BoB. Type a number to choose a transaction:");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdrawal");
            Console.WriteLine("3. Bill Payment");
            Console.WriteLine("4. Account Balance Update");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine($"You have ${balance} in you account. How much to deposit?");
                double deposit = Convert.ToDouble(Console.ReadLine());
                balance = balance - 0.75;
                Console.WriteLine($"You now have ${balance + deposit} in your account.");
            }
            else if (choice == 2)
            {
                Console.WriteLine($"You have ${balance} in you account. How much to Withdrawal?");
                double withdrawal = Convert.ToDouble(Console.ReadLine());
                balance = balance - 0.75;
                Console.WriteLine($"You now have ${balance - withdrawal} in your account.");
            }
            else if (choice == 3)
            {
                Console.WriteLine($"You have ${balance} in you account. How much to pay?");
                double pay = Convert.ToDouble(Console.ReadLine());
                balance = balance - 0.75;
                Console.WriteLine($"You now have ${balance - pay} in your account.");
            }
            else
            {
                Console.WriteLine($"You have ${balance - 0.75} in your account.");
            }
            Console.WriteLine();
            Console.WriteLine("Part 2 - Parking Garage Cost:");
            Console.WriteLine("How many minutes would you like to park?");
            int minutes = Convert.ToInt32(Console.ReadLine());
            if (minutes > 540)
            {
                Console.WriteLine("$20.00 please.");
            }
            else if (minutes > 480)
            {
                Console.WriteLine("$18.00 please.");
            }
            else if (minutes > 420)
            {
                Console.WriteLine("$16.00 please.");
            }
            else if (minutes > 360)
            {
                Console.WriteLine("$16.00 please.");
            }
            else if (minutes > 300)
            {
                Console.WriteLine("$14.00 please.");
            }
            else if (minutes > 240)
            {
                Console.WriteLine("$12.00 please.");
            }
            else if (minutes > 180)
            {
                Console.WriteLine("$10.00 please.");
            }
            else if (minutes > 120)
            {
                Console.WriteLine("$8.00 please.");
            }
            else if (minutes > 60)
            {
                Console.WriteLine("$6.00 please.");
            }
            else
            {
                Console.WriteLine("$4.00 please.");
            }
            Console.WriteLine();
            Console.WriteLine("Part 3 - Hurricane");
            Console.WriteLine("Emter a hurricane category:");
            int category = Convert.ToInt32(Console.ReadLine());
            switch (category)
            {
                case 1:
                    Console.WriteLine("74-95 mph or 64-82 kt or 119-153 km/hr");
                    break;
                case 2:
                    Console.WriteLine("96-110 mph or 83-95 kt or 154-177 km/hr");
                    break;
                case 3:
                    Console.WriteLine("111-130 mph or 96-113 kt or 178-209 km/hr");
                    break;
                case 4:
                    Console.WriteLine("131-155 mph or 114-135 kt or 210-249 km/hr");
                    break;
                case > 4:
                    Console.WriteLine("Greater than 155 mph or 135 kt or 249 km/hr");
                    break;
            }
        }
    }
}