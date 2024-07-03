/************************************
Course: cse 251
File: team11-1
Week: week 11 - team activity 1

Instructions:

- Main contains an array of 10,000,000 random values.  You will be
  creating threads to process this array.  If you find a prime
  number, display it to the console.

- DON'T copy/slice the array in Main() for each thread.

Part 1:
- Create a class that is a subclass of Thread.
- create 4 threads based on this class you created.
- Divide the array among the threads.

Part 2:
- Create a class on an interface or Runnable
- create 4 threads based on this class you created.
- Divide the array among the threads.

Part 3:
- Modify part1 or part 2 to handle any size array and any number
  of threads.

************************************/

public static class Program {

    static bool IsPrime(int n) 
    { 
        // Corner cases 
        if (n <= 1) return false; 
        if (n <= 3) return true; 
    
        // This is checked so that we can skip  
        // middle five numbers in below loop 
        if (n % 2 == 0 || n % 3 == 0) return false; 
    
        for (int i = 5; i * i <= n; i = i + 6) 
            if (n % i == 0 || n % (i + 2) == 0) 
                return false; 
    
        return true; 
    }

    public static void Main(String[] args) {
        Console.WriteLine("Hello world!");

        // create instance of Random class 
        Random rand = new Random(); 

        int count = 10_000_000;
        int[] array = new int[count];
        for (int i = 0; i < count; i++) 
        {
            array[i] = rand.Next();
        }

        // TODO - this is just sample code. you can remove it.
        for (int i = 0; i < count; i++)
        {
            if (IsPrime(array[i]))
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}