using System.Text;

namespace Methods04PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();


            Console.WriteLine(PasswordChecker(password));
        }

        static string PasswordChecker(string password)
        {
            int invalidCharacterCounter = 0;
            bool passwordIsValid = true;
            StringBuilder sb = new StringBuilder();
            int numbersCounter = 0;

            if (password.Length < 6 || password.Length > 10)
            {
                sb.AppendLine("Password must be between 6 and 10 characters");
                passwordIsValid = false;
            }

            for (int i = 0; i < password.Length; i++)
            {
                char currentChar = password[i];

                if ((currentChar >= 48 && currentChar <= 57) || (currentChar >= 65 && currentChar <= 90) ||
                    (currentChar >= 97 && currentChar <= 122))
                {
                    if (currentChar >= 48 && currentChar <= 57)
                    {
                        numbersCounter++;
                    }
                }
                else
                {
                    if (invalidCharacterCounter == 0)
                    {
                        sb.AppendLine("Password must consist only of letters and digits");
                        passwordIsValid = false;
                        invalidCharacterCounter++;
                    }

                }
            }

            if (numbersCounter < 2)
            {
                sb.AppendLine("Password must have at least 2 digits");
                passwordIsValid = false;
            }

            if (passwordIsValid)
            {
                sb.Clear();
                sb.Append("Password is valid");
                return sb.ToString();
            }

            return sb.ToString();
        }
    }
}
