
bool runProgram = true;

//arrays
string[] names = { "Justin Jones", "Connor Wood", "Kris Pranger", "Josh Carolin", "Krista Anderson", "Travis Amador", "Asia Drew", "Ali Al-Hashemi", "Vinh Dang", "Tolulope Olubunmi", "Robot Haupt", "Matt Fox", "Daniel Schuler", "Anthony Ventura", "Mara Johnson", "Brandon Harman", "Olukayode Olubunmi" };
string[] foods = { "Baja Blast", "Chicken Sandwich", "Sushi", "Naleśniki", "Sushi", "General Tso's", "Jerk chicken", "Steak", "Sushi", "Rice and Dodo", "Bread", "Steak", "BBQ", "Thai", "tacos", "Pasta", "Pounded Yam" };
string[] hometown = { "Wyoming, MI", "Grosse Pointe, MI", "Grosse Pointe, MI", "Westland, MI", "Grosse Ile, MI", "Brown City, MI", "Detroit, MI", "Dearborn Heights, MI", "Shelby, MI", "Asese, Nigeria", "Green Bay, WI", "Sterling Heights, MI", "Potterville, MI", "Canton, MI", "Rochester, MI", "Dallas, TX", "Ibadan, Nigeria" };

while (runProgram)
{
    Console.WriteLine("Welcome to the student database!");
    Console.WriteLine("Would you like to see a student list? y/n");
    string studentListChoice = Console.ReadLine();
    if(studentListChoice.ToLower() == "y")
    {
        for (int i = 0; i < names.Length; i++)
        {
            int studentIndex = (i + 1);
            Console.WriteLine(studentIndex + ": " + names[i]);
        }
    }
    Console.WriteLine("Enter a number 1-17");

    int index = int.Parse(Console.ReadLine()) -1;

    if (index < 0 || index > names.Length -1)
    {
        Console.WriteLine("That selection is not an option, please enter a selection between 1-17");
        continue;
    }
    else
    {
        Console.WriteLine($"Student {index + 1} is {names[index]}.");
        Console.WriteLine("What would you like to know? Enter \"hometown\" or \"favorite food\".");
        while (true)
        {
            string category = Console.ReadLine();

            if (category.ToLower() == "hometown")
            {
                Console.WriteLine($"{names[index]} is from {hometown[index]}");

                break;
            }
            else if (category.ToLower() == "favorite food")
            {
                Console.WriteLine($"{names[index]}'s favorite food is {foods[index]}.");

                break;
            }
            else
            {
                Console.WriteLine("This category does not exist. Please Enter \"hometown\" or \"favorite food\"");
            }
        }
    }

    Console.WriteLine("Would you like to learn about another student? y/n");
    string response = Console.ReadLine();
    while (true)
    {
        if (response.ToLower() == "y")
        {
            
            break;
        }
        else if (response.ToLower() == "n")
        {
            Console.WriteLine("Goodbye!");
            runProgram = false;
            break;
        }
    }
}



//Hint for picking student by name -- if (input.Any(char.IsDigit))
