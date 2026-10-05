using System;

class Program
{
    static void Main()
    {
        // Declare and initialize variables of different data types
        byte myByte = 10;
        short myShort = 1000;
        int myInt = 42;
        long myLong = 100000L;
        float myFloat = 3.14f;
        double myDouble = 3.14159;
        decimal myDecimal = 99.99m;
        char myChar = 'A';
        bool myBool = true;

        // Convert integer 42 to a string
        string intToString = myInt.ToString();

        // Convert string "3.14" to a double
        double stringToDouble = Convert.ToDouble("3.14");

        // Print all variables with their types and values
        Console.WriteLine($"byte    - Type: {myByte.GetType()}, Value: {myByte}");
        Console.WriteLine($"short   - Type: {myShort.GetType()}, Value: {myShort}");
        Console.WriteLine($"int     - Type: {myInt.GetType()}, Value: {myInt}");
        Console.WriteLine($"long    - Type: {myLong.GetType()}, Value: {myLong}");
        Console.WriteLine($"float   - Type: {myFloat.GetType()}, Value: {myFloat}");
        Console.WriteLine($"double  - Type: {myDouble.GetType()}, Value: {myDouble}");
        Console.WriteLine($"decimal - Type: {myDecimal.GetType()}, Value: {myDecimal}");
        Console.WriteLine($"char    - Type: {myChar.GetType()}, Value: {myChar}");
        Console.WriteLine($"bool    - Type: {myBool.GetType()}, Value: {myBool}");

        Console.WriteLine($"int to string - Type: {intToString.GetType()}, Value: {intToString}");
        Console.WriteLine($"string to double - Type: {stringToDouble.GetType()}, Value: {stringToDouble}");
    }
}