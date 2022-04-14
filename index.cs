// A school method based C# program to
// check if a number is prime
using System;
 
class GFG {
    // function check whether a
    // number is prime or not
    static bool isPrime(int n)
    {
        // Corner case
        if (n <= 1)
            return false;
 
        // Check from 2 to sqrt(n)
        for (int i = 2; i < Math.Sqrt(n); i++)
            if (n % i == 0)
                return false;
 
        return true;
    }
 
    // Driver Code
    static void Main()
    {
        if (isPrime(11))
            Console.Write(" true");
 
        else
            Console.Write(" false");
    }
}