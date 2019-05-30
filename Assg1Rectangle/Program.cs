using System;

namespace Assg1Rectangle
{
    class Program
    {        

        static void Main(string[] args)
        {            
            Program program = new Program();

            //Initializes the Rectangle.
            Rectangle rectangle = program.InitializeRectangle();

            //Provides the user with menu options.
            Console.WriteLine("Please Select one of the following menu options");
            int menuSelection;
            //Validates the Menu Selection
            menuSelection = program.ValidateMenuSelection();

            //Decision based upon menu selection
            switch (menuSelection)
            {
                case 1:
                    Console.WriteLine("Length of Rectangle is " + rectangle.GetLength());
                    break;

                case 2:
                    Console.WriteLine("Enter the new Length of Rectangle");
                    int newLength = program.ValidateUserInput(Console.ReadLine());
                    Console.WriteLine(rectangle.SetLength(newLength));
                    break;

                case 3:
                    Console.WriteLine("Width of Rectangle is " + rectangle.GetWidth());
                    break;

                case 4:
                    Console.WriteLine("Enter the new Width of Rectangle");
                    int newWidth = program.ValidateUserInput(Console.ReadLine());
                    Console.WriteLine(rectangle.SetLength(newWidth));
                    break;

                case 5:
                    Console.WriteLine("Perimeter of Rectangle is " + rectangle.GetPerimeter());
                    break;

                case 6:
                    Console.WriteLine("Area of Rectangle is " + rectangle.GetArea());
                    break;

                case 7:
                    break;
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        public Rectangle InitializeRectangle()
        {
            Program program = new Program();
            // variables to store user input.
            int length;
            int width;

            //Prompting the user for length of rectangle.
            Console.WriteLine("Please enter the length of rectangle");
            length = program.ValidateUserInput(Console.ReadLine());

            //Prompting the user for width of rectangle.
            Console.WriteLine("Please enter the width of rectangle");
            width = program.ValidateUserInput(Console.ReadLine());

            Rectangle rectangle = new Rectangle(length, width);
            return rectangle;
        }

        public int ValidateUserInput(String input)
        {
            int number = 1;
            bool isValid = false;
            

            while(isValid == false)
            {            
                
                bool result = int.TryParse(input, out number);

                if(result == false)
                {
                    Console.WriteLine("Inavlid input,Please Try again.");              
                }
                else if(number < 0)
                {
                    Console.WriteLine("Invalid input,Cannot enter a negative value.");
                }
                else
                {
                    isValid = true;
                    return number;
                }
                
            }
            return number;
        }

        public int ValidateMenuSelection()
        {
            bool validSelection = false;
            string userInput = String.Empty;

            while(validSelection == false)
            {
                Console.WriteLine("1. Get rectangle Length");
                Console.WriteLine("2. Change rectangle Length");
                Console.WriteLine("3. Get rectangle Width");
                Console.WriteLine("4. Change rectangle Width");
                Console.WriteLine("5. Get rectangle Perimeter");
                Console.WriteLine("6. Get rectangle Area");
                Console.WriteLine("7. Exit\n");

                Console.WriteLine("Enter the number for the required option \n");

                userInput = Console.ReadLine();
                if ( userInput != "1" &&
                    userInput != "2" &&
                    userInput != "3" &&
                    userInput != "4" &&
                    userInput != "5" &&
                    userInput != "6" &&
                    userInput != "7" )
                {
                    Console.WriteLine("Invalid Menu option selected, Please select a valid option \n");
                }
                else
                {
                    validSelection = true;
                }

            }
            return int.Parse(userInput);
        }
    }
}
