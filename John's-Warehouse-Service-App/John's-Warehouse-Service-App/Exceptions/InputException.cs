using System;

namespace John_s_Warehouse_Service_App.Exceptions
{
    internal static class InputException
    {
        // Read Integer
        public static int ReadInt(string message)
        {
            int value;

            while (true)
            {
                Console.Write(message);

                if (int.TryParse(Console.ReadLine(), out value) && value >= 0)
                    return value;

                Console.WriteLine("Invalid input. Please enter a positive whole number.");
            }
        }

        // Read Decimal
        public static decimal ReadDecimal(string message)
        {
            decimal value;

            while (true)
            {
                Console.Write(message);

                if (decimal.TryParse(Console.ReadLine(), out value) && value >= 0)
                    return value;

                Console.WriteLine("Invalid input. Please enter a positive decimal number.");
            }
        }

        // Read Double
        public static double ReadDouble(string message)
        {
            double value;

            while (true)
            {
                Console.Write(message);

                if (double.TryParse(Console.ReadLine(), out value) && value >= 0)
                    return value;

                Console.WriteLine("Invalid input. Please enter a positive number.");
            }
        }

        // Read Boolean (Yes/No, True/False)
        public static bool ReadBool(string message)
        {
            while (true)
            {
                Console.Write(message);

                string input = Console.ReadLine().Trim().ToLower();

                switch (input)
                {
                    case "true":
                    case "t":
                    case "yes":
                    case "y":
                    case "1":
                        return true;

                    case "false":
                    case "f":
                    case "no":
                    case "n":
                    case "0":
                        return false;

                    default:
                        Console.WriteLine("Invalid input. Enter Yes/No or True/False.");
                        break;
                }
            }
        }

        // Read String
        public static string ReadString(string message)
        {
            while (true)
            {
                Console.Write(message);

                string value = Console.ReadLine().Trim();

                if (!string.IsNullOrWhiteSpace(value))
                    return value;

                Console.WriteLine("Value cannot be empty.");
            }
        }

        // Read Email
        public static string ReadEmail(string message)
        {
            while (true)
            {
                Console.Write(message);

                string email = Console.ReadLine().Trim();

                if (!string.IsNullOrWhiteSpace(email) &&
                    email.Contains("@") &&
                    email.Contains("."))
                {
                    return email;
                }

                Console.WriteLine("Invalid email address.");
            }
        }

        // Read Phone Number
        public static string ReadPhone(string message)
        {
            while (true)
            {
                Console.Write(message);

                string phone = Console.ReadLine().Trim();

                if (!string.IsNullOrWhiteSpace(phone) && phone.Length >= 10)
                    return phone;

                Console.WriteLine("Invalid phone number.");
            }
        }

        // Read Menu Choice
        public static string ReadMenuChoice(int minOption, int maxOption)
        {
            while (true)
            {
                Console.Write("Select an option: ");

                string input = Console.ReadLine();

                if (int.TryParse(input, out int choice))
                {
                    if (choice >= minOption && choice <= maxOption)
                        return input;
                }

                Console.WriteLine("Invalid menu option. Please try again.");
            }
        }
    }
}