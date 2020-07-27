using System;
using System.Reflection.Metadata.Ecma335;
using System.Threading;

namespace Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool isInvalid = false;
            if ((PasswordIsBtween2And10Chars(password)))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                isInvalid = true;
            }

            if ((PasswordConsistOnlyLettersAndDigits(password)))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                isInvalid = true;
            }
            
            if ((PasswordMustHave2Digits(password)))
            {
                Console.WriteLine("Password must have at least 2 digits");
                isInvalid = true;
            }

            if (!isInvalid)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool PasswordIsBtween2And10Chars(string pass)
        {
            bool isValid = false;
            if (!(pass.Length >= 6 && pass.Length <= 10))
            {
                isValid = true;
            }
            return isValid;
        }
        

        static bool PasswordConsistOnlyLettersAndDigits(string pass)
        {
            bool isValid = false;
            for (int i = 0; i < pass.Length; i++)
            {
                if (!(((pass[i] >= 48 && pass[i] <= 57)) 
                    || ((pass[i] >= 65 && pass[i] <= 91))
                    || ((pass[i] >= 97 && pass[i] <= 122))))
                {
                    isValid = true;
                    break;
                }
            }
            return isValid;
        }

        static bool PasswordMustHave2Digits(string pass)
        {
            bool isValid = false;
            int count = 0;
            for (int i = 0; i < pass.Length; i++)
            {
                if (pass[i] >= 48 && pass[i] <= 57)
                {
                    count++;
                }
            }
            if (count < 2 )
            {
                isValid = true;
            }
            return isValid;
        }
    }
}
