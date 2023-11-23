using System.Text.RegularExpressions;

namespace TheUserProfiler
{
    internal partial class Program
    {

        public static void ValidShowMessage(string message)
        {
            Console.WriteLine("Valid");
        }

        public static void InvalidShowMessage(string message)
        {
            Console.WriteLine("Please enter valid input!");
        }

        [GeneratedRegex("^[a-zA-Z]+$")]
        public static partial Regex MyRegexName();

        [GeneratedRegex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")]
        public static partial Regex MyRegexEmail();

        static void Main(string[] args)
        {
            Console.Title = "The User Profiler";
            Console.WriteLine("Hello!");

            bool ValidInfo = false;

            // Using a for loop

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter your first name:");
                var name = Console.ReadLine();
                if (!string.IsNullOrEmpty(name) && MyRegexName().IsMatch(name))
                {
                    Console.WriteLine("Nice to meet you " + name);
                    ValidInfo = true;
                    break;
                }
                else
                {
                    InvalidShowMessage($"{name}");
                    ValidInfo = false;
                }
            }
            if (!ValidInfo)
            {
                Console.WriteLine("Inavalid first name!");
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter your last name:");
                var name = Console.ReadLine();
                if (!string.IsNullOrEmpty(name) && MyRegexName().IsMatch(name))
                {
                    ValidShowMessage(name);
                    ValidInfo = true;
                    break;
                }
                else
                {
                    InvalidShowMessage($"{name}");
                    ValidInfo = false;
                }
            }
            if (!ValidInfo)
            {
                Console.WriteLine("Inavalid last name!");
            }

            // Using a while loop

            int attempts = 0;
            while (attempts < 3)
            {
                Console.WriteLine("Enter your birthday (MM/DD/YYYY):");
                var str = Console.ReadLine();
                if (!string.IsNullOrEmpty(str) && DateTime.TryParse(str, out _))
                {
                    ValidShowMessage(str);
                    ValidInfo = true;
                    break;
                }
                else
                {
                    InvalidShowMessage($"{str}");
                    ValidInfo = false;
                }
                attempts++;
            }
            if (!ValidInfo)
            {
                Console.WriteLine("Invalid date of birth!");
            }

            int tried = 0;
            while (tried < 3)
            {
                Console.WriteLine("Please Enter your gender:");
                var gender = Console.ReadLine();
                if (!string.IsNullOrEmpty(gender) && (gender.ToUpper() == "MALE" || gender.ToUpper() == "FEMALE"))
                {
                    ValidShowMessage(gender);
                    ValidInfo = true;
                    break;
                }
                else
                {
                    InvalidShowMessage($"{gender}");
                    ValidInfo = false;
                }
                tried++;
            }
            if (!ValidInfo)
            {
                Console.WriteLine("Invalid gender!");
            }

            // Using a do-while loop

            int x = 0;
            do
            {
                Console.WriteLine("Enter your email address:");
                var email = Console.ReadLine();
                if (!string.IsNullOrEmpty(email) && MyRegexEmail().IsMatch(email))
                {
                    ValidShowMessage(email);
                    ValidInfo = true;
                    break;
                }
                else
                {
                    InvalidShowMessage($"{email}");
                    ValidInfo = false;
                }
                x++;
            } while (x < 3);
            if (!ValidInfo)
            {
                Console.WriteLine("Invalid email address!");
            }

            int y = 0;
            do
            {
                Console.WriteLine("Please enter your phone number:");
                var phoneNumber = Console.ReadLine();
                if (!string.IsNullOrEmpty(phoneNumber) && phoneNumber.Length == 11)
                {
                    string subphoneNumber = phoneNumber.Substring(0, 1);
                    if (subphoneNumber == "09")
                    {
                        ValidShowMessage(phoneNumber);
                        ValidInfo = true;
                        break;
                    }
                    else
                    {
                        InvalidShowMessage($"{phoneNumber}");
                        ValidInfo = false;
                    }
                }
                y++;
            } while (y < 3);
            if (!ValidInfo)
            {
                Console.WriteLine("Invalid phone number!");
            }
        }
    }
}