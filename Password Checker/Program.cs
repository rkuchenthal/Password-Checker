using System;

namespace Password_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int passScore = 0;
            string lower = "abcdefghijklmnopqrstuvwxyz";
            string upper = "ABCDEFGHIJKLMNOPQRSTUZWXYZ";
            string special = "!@#$%^&*~`?><";
            string digits = "0123456789";
            int minLength = 8;

            //prompt user
            Console.WriteLine("Enter password: ");
            string pass = Console.ReadLine();

            //check for min length
            if (pass.Length > minLength) passScore++;
            //check for upper case
            if (Tools.Contains(pass, upper)) passScore++;
            //check for lower case
            if (Tools.Contains(pass, lower)) passScore++;
            //check for special chars
            if (Tools.Contains(pass, special)) passScore++;
            //check for numbers
            if (Tools.Contains(pass, digits)) passScore++;

            //print score of password
            switch (passScore)
            {
                case (0):
                    Console.WriteLine("Password is very weak.");
                    break;
                case (1):
                    Console.WriteLine("Password is weak.");
                    break;
                case (2):
                    Console.WriteLine("Password is ok.");
                    break;
                case (3):
                    Console.WriteLine("Password is good.");
                    break;
                case (4):
                    Console.WriteLine("Password is very good.");
                    break;
                default:
                    Console.WriteLine("Password is excellent.");
                    break;
            }

        }
    }
}
