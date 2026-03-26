namespace Topic_8___Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Topic 8 ~ Lists";

            // A List allows us to store multiple variables of the same datatype. 
            // Ex. String name1, name2, name;

            List<string> names = new List<string> { "Trinity", "Neo", "Morpheus", "Smith" };
            Console.WriteLine(names[1] + " is 'The One'.");
            Console.WriteLine(names[3] + " is the bad guy.");
            Console.WriteLine("There are " + names.Count + " names in my List.");
            names[3] = "Agent Smith";
            Console.WriteLine(names[3] + " is the bad guy.");
            Console.ReadLine(); 

            /**
            
            1) What does the number mean in the square brackets names[1]?? (Referred to as index)
                

            **/
        }
    }
}
