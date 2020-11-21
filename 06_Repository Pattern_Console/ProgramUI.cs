using _06_RepositoryPattern_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Repository_Pattern_Console
{
    class ProgramUI
    {
        private StreamingContentRepository _contentRepo = new StreamingContentRepository();


        //Method that runs/starts the application (UI part)
        public void Run()
        {
            Menu();
        }

        // Menu
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {



                // Display our options to the user
                Console.WriteLine("Select a menu option:\n" +
                    "1. Create New Content\n" +
                    "2. View All Content\n" +
                    "3. View Content By Title\n" +
                    "4. Update Existing Content\n" +
                    "5. Delete Existing Content\n" +
                    "6. Exit");

                //Get the user's input
                string input = Console.ReadLine();

                //Evaluate the user's input and act accordingly
                switch (input)
                {
                    case "1":
                        //Create new content
                        CreateNewContent();
                        break;
                    case "2":
                        DisplayAllContent();
                        break;
                    case "3":
                        DisplayContentByTitle();
                        break;
                    case "4":
                        UpdateExistingContent();
                        break;
                    case "5":
                        DeleteExistingContent();
                        break;
                    case "6":
                        Console.WriteLine("Goodbye!");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number.");
                        break;
                }

                Console.WriteLine("Please press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        //Create new Streaming Content
        private void CreateNewContent()
        {
            Console.Clear();
            StreamingContent newContent = new StreamingContent();

            // Title
            Console.WriteLine("Enter the title for the content:");
            newContent.Title = Console.ReadLine();

            //Description
            Console.WriteLine("Enter the description for the content:");
            newContent.Description = Console.ReadLine();

            //Maturity Rating
            Console.WriteLine("Enter the rating for the content (G, PG, PG-13, etc.):");
            newContent.MaturityRating = Console.ReadLine();

            //Star Rating
            Console.WriteLine("Enter the star count for the content (5.8, 10, 1.5, etc.)");
            string starsAsString = Console.ReadLine();
            newContent.StarRating = double.Parse(starsAsString);

            //IsFamilyFriendly
            Console.WriteLine("Is this content family friendly? (y/n)");
            string familyFriendlyString = Console.ReadLine().ToLower();  //.ToLower means that if user inputs an uppercase letter (Y/N), it wil automatically be converted to lowercase.

            if(familyFriendlyString == "y")
            {
                newContent.IsFamilyFriendly = true;
            }
            else
            {
                newContent.IsFamilyFriendly = false;
            }


            //GenreType

            Console.WriteLine("Enter the Genre Number:\n" +
                "1. Horror\n" +
                "2. RomCom\n" +
                "3. SciFi\n" +
                "4. Documentary\n" +
                "5. Bromance\n" +
                "6. Drama\n" +
                "7. Action");

            string genreAsString = Console.ReadLine();
            int genreAsInt = int.Parse(genreAsString);   // .Parse took string and converted it into an integer (number)
            newContent.TypeOfGenre = (GenreType)genreAsInt;

            _contentRepo.AddContentToList(newContent);

        }

        //View current streamingContent that is saved
        private void DisplayAllContent()
        {

        }

        //View existing Content by title
        private void DisplayContentByTitle()
        {

        }

        //Update existing Content
        private void UpdateExistingContent()
        {

        }

        //Delete existing Content
        private void DeleteExistingContent()
        {

        }
    }
}
