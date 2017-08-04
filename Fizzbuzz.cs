    public class Fizzbuzz
    {
        public static void Main(string[] args)
        {
            for(int i = 1; i <= 100; i++) // Loop from 1-100
            {
                
                if(i % 3 == 0 && i % 5 == 0) // If the current number is divisble by both...
                    Console.WriteLine("FizzBuzz"); // Print "Fizzbuzz"
                
                else if (i % 3 == 0) // If the current number is divisible by 3...
                    Console.WriteLine("Fizz"); // Print "Fizz"
                    
                else if (i % 5 == 0) // If the current number is divisble by 5...
                    Console.WriteLine("Buzz"); // Print "Buzz"
                    
                else // or else...
                    Console.WriteLine(i); // Print the number.
            }          
        }
    }
