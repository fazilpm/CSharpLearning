// This is a comment - computer ignore it
// Use comments to explain your code to yourself and others. Comments are ignored by the compiler and do not affect the execution of your program.
/*
//Arrays
int[] array = new int[5]; // Declare an array of integers with a size of 5
array[0] = 10; // Assign the value 10 to the first element of the array
array[1] = 20; // Assign the value 20 to the second element of the array
array[2] = 30; // Assign the value 30 to the third element of the array
array[3] = 40; // Assign the value 40 to the fourth element of the array
array[4] = 50; // Assign the value 50 to the fifth element of the array
Console.WriteLine("Array elements:"); // Print a message to the console
Console.WriteLine(array[0]); // Print the first element of the array to the console
Console.WriteLine(array[1]); // Print the second element of the array to the console
Console.WriteLine(array[2]); // Print the third element of the array to the console
Console.WriteLine(array[3]); // Print the fourth element of the array to the console
Console.WriteLine(array[4]); // Print the fifth element of the array to the console
*/

/*
//Comments - XML Documentation Comments
public class Program
{
    /// <summary>
    /// The main entry point of the program.
    /// </summary>
    /// <param name="args">Command-line arguments.</param>
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!"); // Print a greeting message to the console
    }
} */

/*
// if else statement
Console.WriteLine("Enter Age:"); // Prompt the user to enter their age
int age = int.Parse(Console.ReadLine()); // Read the user's input and convert it to an integer
if (age > 0)
{
    Console.WriteLine("The age is positive.");
}
else
{
    Console.WriteLine("The age is not positive.");
}
Console.WriteLine("Enter Name:"); // Prompt the user to enter their name
string name = Console.ReadLine(); // Read the user's input
if(string.IsNullOrEmpty(name))
{
    Console.WriteLine("Name is empty.");
}
else if (name == "Fazil")   
{
    Console.WriteLine($"Hello, Fazil! your age is {age}.");
}
else
{
    Console.WriteLine($"Hello, {name}!");
}*/

/*
//Switch statement
Console.WriteLine("Enter a number between 1 and 3:"); // Prompt the user to enter a number
int number = int.Parse(Console.ReadLine()); // Read the user's input and convert it to an integer
switch (number) // Start a switch statement based on the value of 'number'
{
    case 1: // If 'number' is 1
        Console.WriteLine("You entered one."); // Print a message to the console
        break; // Exit the switch statement
    case 2: // If 'number' is 2
        Console.WriteLine("You entered two."); // Print a message to the console
        break; // Exit the switch statement
    case 3: // If 'number' is 3
        Console.WriteLine("You entered three."); // Print a message to the console
        break; // Exit the switch statement
    default: // If 'number' is not 1, 2, or 3
        Console.WriteLine("Invalid number."); // Print an error message to the console
        break; // Exit the switch statement
}*/

/*
//for loop
int[] numbers = { 1, 2, 3, 4, 5 }; // Declare and initialize an array of integers with values from 1 to 5

for (int i = 0; i < numbers.Length; i++) // Initialize a for loop that runs 5 times
{
    Console.WriteLine($"Element at index {i}: {numbers[i]}"); // Print the current index and its corresponding value in the array
}
//foreach loop
foreach (int number in numbers) // Initialize a foreach loop that iterates through each element in the 'numbers' array
{
    Console.WriteLine($"Number: {number}"); // Print the current number to the console
}
*/
/*
//pass by reference example 
public class Program
{
    public static void Main(string[] args)
    {
        int number = 5;
        Console.WriteLine($"Before method call: {number}");
        Increment(ref number);
        Console.WriteLine($"After method call: {number}");
    }
    public static void Increment(ref int value)
    {
        value++;
    }
}
*/

class Program
{
    static void Main(string[] args)
    {
        projectA.teamA.classA.Display(); // Call the Display method from classA in teamA namespace
        projectA.teamB.classA.Display(); // Call the Display method from classA in teamB namespace
    }
}

//Namespaces
namespace projectA
{
    namespace teamA
    {
        class classA
        {
            public static void Display()
            {
                Console.WriteLine("TeamA display method");
            }
        }
    }

}
namespace projectA
{
    namespace teamB
    {
        class classA
        {
            public static void Display()
            {
                Console.WriteLine("TeamB display method");
            }
        }
    }

}