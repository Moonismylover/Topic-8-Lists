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

            List<string> names = new List<string> { "Trinity", "Neo", "Morpheus", "Smith", "Sliver", "Layla"};
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



        }
    }
}
