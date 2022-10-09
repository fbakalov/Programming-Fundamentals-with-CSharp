using System;
using System.Linq;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            char[] splitedPass = password.ToCharArray();

            bool isValid = true;
            if (Is6to10(splitedPass) == false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                isValid = false;
            }
            if (ContainOnlyLettersDigits(password) == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
                isValid = false;
            }
            if (AtLeast2Digets(password) == false)
            {
                Console.WriteLine("Password must have at least 2 digits");
                isValid = false;
            }

            if (isValid == true)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool Is6to10(char[] pass)
        {
            bool is6to10 = pass.Length >= 6 && pass.Length <= 10;
            return is6to10;
        }

        static bool ContainOnlyLettersDigits(string pass)
        {
            foreach (char ch in pass)
            {
                if (!Char.IsLetterOrDigit(ch))
                {
                    return false;
                }
            }
            return true;          
        }

        static bool AtLeast2Digets(string pass)
        {
            int digtCount = 0;
            foreach (char ch in pass)
            {
                if (Char.IsDigit(ch))
                {
                    digtCount++;
                }
            }
            return digtCount >= 2;
        }
    }
}
