using System;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            bool result = CheckPassLength(inputString);
            bool consist = ConsistOfLettersDigits(inputString);
            int countDigits = CheckDigitsCount(inputString);

            if (countDigits < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");               
            }
            
            if ((countDigits >= 2) && 
                  (result == true) &&
                  (consist == true))
            {
                Console.WriteLine("Password is valid");
            }  
        }

        static bool CheckPassLength(string passLength) 
        {            
            if ((passLength.Length < 6) || (passLength.Length > 10))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                return false;
            }

            return true;
        }

        static bool ConsistOfLettersDigits(string inputString)
        {

            for (int i = 0; i < inputString.Length; i++)
            {                
                char currCharacter = inputString[i];

                if (Char.IsLetterOrDigit(currCharacter) == false)
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    return false;                    
                }
            }

            return true ;
        }

        static int CheckDigitsCount(string inputString) 
        {
            int countDigits = 0;

            for (int i = 0; i < inputString.Length; i++)
            {
                char currCharacter = inputString[i];
                
                if (Char.IsDigit(currCharacter) == true)
                {
                    countDigits += 1;                   
                }                           
            }

            return countDigits;

        }
    }
}
