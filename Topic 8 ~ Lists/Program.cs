using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.X86;
using System.Threading.Channels;
using System.Timers;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Topic_8___Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Topic 8 ~ Lists";

            // A List allows us to store multiple variables of the same datatype. 
            // Ex. String name1, name2, name;

            Random generator = new Random();

            List<string> names = new List<string> { "Trinity", "Neo", "Morpheus", "Smith", "Sliver", "Layla" };
            Console.WriteLine(names[1] + " is 'The One'.");
            Console.WriteLine(names[3] + " is the bad guy.");
            Console.WriteLine(names[4] + " is the best!");
            Console.WriteLine("There are " + names.Count + " names in my List.");
            names[3] = "Agent Smith";
            Console.WriteLine(names[3] + " is the bad guy.");
            names[names.Count - 1] = "Cypher";
            Console.WriteLine(names[names.Count - 1] + " is the best!");
            int num = generator.Next(0, 5);
            Console.WriteLine($"{names[num]} is awesome!");
            Console.ReadLine();

            /**
            
            1) What does the number mean in the square brackets: names[1]?? (Referred to as index)
               It represents the order of the numbers in the sequence of the list.
            2) How could you print out the first name (Trinity) in names?
               Console.WriteLine(names[0]);
            3) When the List is declared, add another name.
            4) What do you think names.Count does? 
               It counts the number of names in the list. 
            5) Change the name stored in the last position to "Cypher" and then print it. 
               Challenge: Use names.Count to change the last name instead of using the index number.
            6) Challenge: Can you print a 'random' name from the list? (random # for index)

            **/

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(i + ". " + names[i]);
            }

            /**
            
            1) How does using a loop help us to more quickly print the contents of this List?
               It allows us to print all the names in one go. 
            2) From the line that you declare the List names, remove the extra name you added so there are only 4 names, and run your program. 
               What happened? Why? Can you fix the loop so it works?
               It shows an error. You have to change the number of times the loop appears to match the 
               number in the names List.
            3) How can you change the end condition of your for loop (the ‘i < 4’ part) so that it will work
               no matter how many items are in your array?
               You can do i < names.Count. 
               
            1) What would Console.WriteLine(numbers[3]); print to the screen?
               15
            2) What would Console.WriteLine(numbers[1] + numbers[3]); print to the screen?
               22
            3) What would Console.WriteLine(numbers[1 + 3]); print to the screen?
               34
            4) How could you print the last element in this List? (there are 2 possible answers)
               Console.WriteLine(names[names.Count -1]);
               Console.WriteLine(names[7]);
            5) What happens if you try to print: numbers[8]? numbers[-1]?
               You get an error because there is no index 8. 

            **/

            List<int> numbers = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Please enter a number: ");
                numbers.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("The largest number is " + numbers.Max());
            Console.WriteLine("The smallest number is " + numbers.Min());
            Console.WriteLine("The sum is " + numbers.Sum());
            Console.WriteLine("The average is " + numbers.Average());
            Console.ReadLine();

            Random generator2 = new Random();

            List<int> integers = new List<int>();
            for (int a = 0; a < 20; a++)
            {
                integers.Add(generator2.Next(1, 41));
                Console.WriteLine("The average is " + integers.Average());
                Console.WriteLine("The largest number is " + integers.Max());
                Console.WriteLine("The smallest number is " + integers.Min());
            }

            Console.WriteLine("Display all the numbers in a list format on the same line!");

            for (int a = 0; a < integers.Count(); a++)
            {
                if (integers[a] == 10)
                {
                    Console.WriteLine("Ten");
                }
                else if (integers[a] == 20);
                {
                    Console.WriteLine("Twenty");
                }
                else if (integers[a] == 30);
                {
                    Console.WriteLine("Thirty");
                }
                else if (integers[a] == 40)
                {
                    Console.WriteLine("Forty");
                }
                
                Console.WriteLine($"{integers[a]}, ");
            }

            Console.WriteLine("Double List: ");

            for (int a = 0; a < integers.Count; a++)
            {
                integers[a] = a * 2;
                Console.WriteLine($"{integers[a]}, ");
            }

            Console.WriteLine("50 is ZERO!");
            for (int a = 0; a < integers.Count; a++)
            {
                if (integers[a] == 50)
                    integers[a] = 0;
            }

            Console.WritelIne("")
            




            //Programming Task Random List (you may modify the above program if you wish)

//3.Loop through the List and double each number(change the values in the array).
//4.Loop through the List and replace each number that is less than 50 with zero.
//5.Display the numbers in the List on the same line, separated by a space.
//6.Challenge: Use a loop to count the number of zeroes in the List and print it.
// You will need to use a counter variable inside the loop

//Solutions can be found here: https://github.com/AldworthClass/Programming-Task---Random-Lists
        }
    }
}
