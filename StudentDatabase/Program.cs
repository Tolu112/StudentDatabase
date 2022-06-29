Console.WriteLine("Hello, please follow instructions below to access Student information. ");

string[] name = new string[] { "Krista Anderson", "Travis Amador", "Asia Drew", "Ali Al-Hashemi", "Vinh Dang", "Tolulope Olubunmi", "Robot Haupt", "Matt Fox", "Daniel Schuler", "Anthony Ventura", "Mara Johnson", "Brandon Harman", "Olukayode Olubunmi", "Justin Jones", "Connor Wood", "Kris Pranger", "Joshua Carolin" };
string[] favoriteFood = new string[] { "Sushi", "General Tso's", "Jerk Chicken", "Steak", "Sushi", "Rice and Dodo", "Bread", "Steak", "BBQ", "Thai", "Tacos", "Pasta", "Pounded Yam", "Baja Blast", "Chicken Sandwich", "Sushi", "Naleśniki" };
string[] hometown = new string[] { "Grosse Ile, MI", "Brown City, MI", "Detroid, MI", "Dearborn Heights, MI", "Shelby, MI", "Asese, Nigeria", "Green Bay, WI", "Sterling Heights, MI", "Potterville, MI", "Canton, MI", "Rochester, MI", "Dallas, TX", "Ibadan, Nigeria", "Wyoming, Mi", "Grosse Pointe, MI", "Grosse Pointe, MI", "Westland, MI" };
int StudentID = 0;
bool runProgram = true;
while (runProgram)
{
    //Prompt the user to ask about a particular student by number. Provide an option where the user can see a list of all students.
    Console.Write("\n" + "Please enter a valid student ID number (1-17) or enter the word list to see the list of students: ");
    string userInput = (Console.ReadLine().ToLower());

    //Output List of Student Names and IDs
    if (userInput.Contains("list"))
     {
         //Display list
         Console.WriteLine(string.Format("\n{0,15} {1,22}", "Student ID", "Student Name"));
         Console.WriteLine(string.Format("{0,15} {1,25}", "==========", "=================="));

         foreach (string n in name)
         {
             StudentID++;
             Console.Write(string.Format("{0,10}\t\t{1,-20}\n", StudentID, n));
         }
     }
     else
     {
         //Convert the input to an integer. Use the integer as the index for the arrays. Use the first array’s Length property in your code instead of hardcoding it.????- Don't understand this.
         StudentID = int.Parse(userInput) - 1;
         //Validate user number: Use an if statement to check if the number is out of range, i.e.either less than 0 or greater than the maximum index of the arrays.If so, display a friendly message and let the user try again.
         if (StudentID < 0 || StudentID > 16) { Console.WriteLine("\n" + "You have entered an invalid ID number. Please enter an ID number between 1 and 17."); continue; }

         //Display name
         Console.Write($"\n" + "Student ID# " + (StudentID + 1) + ": " + name[StudentID] + "\n");

         //Ask the user which category to display: Hometown or Favorite food.
         //Validate category: Ask the user what information category to display: "Hometown" or "Favorite Food". Use an if statement to check that they entered either category name correctly. If they entered an incorrect category, display a friendly message and re-ask the question.
         bool invalidChoice1 = true;
         while (invalidChoice1)
         {
             Console.Write("\n" + "Select a category to display. Hometown or Favorite Food or Both? ");
             string choice = Console.ReadLine().ToLower().Trim();
             while (true)
             {
                 //allow portion of word such as "Food" instead of "Favorite Food
                 if (choice == "favorite food" || choice == "food" || choice == "favorite" || choice == "hometown" || choice == "home" || choice == "town" || choice == "both")
                 {
                     Console.WriteLine("\n" + "Student ID# " + StudentID + ": " + name[StudentID]);
                     if (choice == "favorite food" || choice == "food" || choice == "favorite") { Console.WriteLine($"Favorite Food: " + favoriteFood[StudentID]); }
                     else if (choice == "hometown" || choice == "home" || choice == "town") { Console.WriteLine($"Hometown: " + hometown[StudentID]); }
                     else if (choice == "both") { Console.WriteLine($"Favorite Food: " + favoriteFood[StudentID] + "\n" + "Hometown: " + hometown[StudentID]); }
                     invalidChoice1 = false; break;
                 }

                 else { Console.WriteLine("\n" + "You have selected an invalid category. Please enter Hometown, or Favorite Food, or Both."); invalidChoice1 = true; break; }
             }

         }
     }
    //Ask the user if they would like to learn about another student.
    Console.Write("\n\n" + "Would you like to learn about another student? y/n? ");
    string choice2 = Console.ReadLine().ToLower().Trim();
    while (true)
    {
        if (choice2 == "y")
        {
            break;
        }
        if (choice2 == "n")
        {
            Console.WriteLine("Goodbye");
            runProgram = false;
            break;
        }
    }
}


            /*bool invalidChoice = true;
            while (invalidChoice)
            {
                Console.Write("\n" + "Select a category to display. Hometown or Favorite Food or Both? ");
                string choice = Console.ReadLine().ToLower().Trim();
                while (true)
                {
                    //allow portion of word such as "Food" instead of "Favorite Food
                    if (choice == "favorite food" || choice == "food" || choice == "favorite" || choice == "hometown" || choice == "home" || choice == "town" || choice == "both")
                    {
                        Console.WriteLine("\n" + "Student ID# " + StudentID + ": " + name[StudentID]);
                        if (choice == "favorite food" || choice == "food" || choice == "favorite") { Console.WriteLine($"Favorite Food: " + favoriteFood[StudentID]); }
                        else if (choice == "hometown" || choice == "home" || choice == "town") { Console.WriteLine($"Hometown: " + hometown[StudentID]); }
                        else if (choice == "both") { Console.WriteLine($"Favorite Food: " + favoriteFood[StudentID] + "\n" + "Hometown: " + hometown[StudentID]); }
                        invalidChoice = false; break;
                    }
                    else { Console.WriteLine("\n" + "You have selected an invalid category. Please enter Hometown, or Favorite Food, or Both."); invalidChoice = true; break; }
                }
            }*/