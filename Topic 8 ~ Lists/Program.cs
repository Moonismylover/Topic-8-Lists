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

            List<string> names = new List<string> { "Trinity", "Neo", "Morpheus", "Smith", "Sliver"};
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
        }
    }
}
