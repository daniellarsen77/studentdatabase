using System;

class Program
{
    static void Main()
    {
        string[] names = { "Tommy", "Tim", "Josh" };
        string[] hometowns = { "Raleigh", "Jackson", "Westland" };
        string[] favoriteFoods = { "Buttered Chicken", "Pho", "Nalésniki" };

        int length = names.Length;

        bool continueLearning = true;

        while (continueLearning)
        {
            Console.WriteLine($"Which student would you like to learn about? Enter a number between 1 and {length}: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int studentNumber) || studentNumber < 1 || studentNumber > length)
            {
                Console.WriteLine($"Sorry, that is an invalid student number. Please enter a number between 1 and {length}.");
                continue;
            }

            string studentName = names[studentNumber - 1];

            Console.WriteLine($"You have selected {studentName}. What category would you like to learn about? Enter 'Hometown' or 'Favorite Food': ");
            string category = Console.ReadLine();

            while (category.ToLower() != "hometown" && category.ToLower() != "favorite food")
            {
                Console.WriteLine($"Sorry, {category} is not a valid category. Please enter 'Hometown' or 'Favorite Food'.");
                category = Console.ReadLine();
            }

            if (category.ToLower() == "hometown")
            {
                Console.WriteLine($"{studentName} is from {hometowns[studentNumber - 1]}.");
            }
            else
            {
                Console.WriteLine($"{studentName}'s favorite food is {favoriteFoods[studentNumber - 1]}.");
            }

            Console.WriteLine("Would you like to learn about another student? Enter 'yes' or 'no': ");
            string continueInput = Console.ReadLine();

            continueLearning = (continueInput.ToLower() == "yes");
        }

        Console.WriteLine("Thank you for using the student information application!");
    }
}
