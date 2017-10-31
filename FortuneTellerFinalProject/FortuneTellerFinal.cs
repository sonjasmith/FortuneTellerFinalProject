using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //Develop a console application that will tell the user’s fortune 
            //based on data received from the user.

            //Variables and Basic Types
            //Operators and Expressions
            //Conditionals
            //Strings

            //Welcome Screen
            Console.WriteLine("Welcome I'm Sonja your favorite Fortune Teller!");
            Console.WriteLine();
            Console.WriteLine("You may exit anytime by typing quit.");
            Console.WriteLine();
                                
            //Ask the user for the user’s first name
            string firstName;
            Console.WriteLine("Please enter your first name: ");
            firstName = Console.ReadLine();
            if (firstName.ToLower() == "quit")
            {
                Console.WriteLine("Nobody likes a quitter looser...");
                System.Environment.Exit(0);
            }

            string lastName;
            Console.WriteLine("\nPlease enter your last name: ");
            lastName = Console.ReadLine();
            if (lastName.ToLower() == "quit")
            {
                Console.WriteLine("Nobody likes a quitter looser...");
                System.Environment.Exit(0);
            }

            //Ask the user for the user’s age. Convert int to a string int numUserAge;
            //Console.WriteLine("Please enter your age");
            //userAge = int.Parse(Console.ReadLine());
            string strUserAge;
            int numUserAge;
            Console.WriteLine("\nPlease enter your age: ");
            strUserAge = Console.ReadLine();
            if (strUserAge.ToLower() == "quit")
            {
                Console.WriteLine("Nobody likes a quitter looser...");
                System.Environment.Exit(0);
            }
            numUserAge = int.Parse(strUserAge);

            //Ask the user for the user’s birth month(as an 'int')
            //Convert int to string
            //int birthMonth;
            //Console.WriteLine("Please enter your birth month using a number");
            //birthMonth = int.Parse(Console.ReadLine());
            string strBirthMonth;
            int birthMonth;
            Console.WriteLine("\nPlease enter your birth month using a number: ");
            strBirthMonth = Console.ReadLine();
            if (strBirthMonth.ToLower() == "quit")
            {
                Console.WriteLine("Nobody likes a quitter looser...");
                System.Environment.Exit(0);
            }
            birthMonth = int.Parse(strBirthMonth);

            //Ask the user for the user’s favorite ROYGBIV color (if statement)
            Console.WriteLine("\nWhat is your favorite ROYGBIV color? Enter 'Help' for a list of ROYGBIV colors: ");
            string color = Console.ReadLine();

            //Changing color to lowercase then perform lowercase comparison.
            if (color.ToLower() == "help")
            {
                Console.WriteLine("\nThese are the colors of ROYGBIV:\n Red\n Orange\n Yellow\n Green\n Blue\n Indigo\n Violet");
                Console.WriteLine("Please enter a ROYGBIV color from the colors above: ");
                color = Console.ReadLine();
            }
            if (color.ToLower() == "quit")
            {
                Console.WriteLine("Nobody likes a quitter looser...");
                System.Environment.Exit(0);
            }

            //Ask the user for the number of siblings the user has
            //Convert int to string
            //int numberOfSiblings = 0;
            //Console.WriteLine("How many siblings do you have?");
            //numberOfSiblings = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            string strNumOfSiblings;
            int numOfSiblings;
            Console.WriteLine("\nHow many siblings do you have?");
            strNumOfSiblings = Console.ReadLine();
            Console.WriteLine();
            if(strNumOfSiblings.ToLower() == "quit")
            {
                Console.WriteLine("Nobody likes a quitter looser...");
                System.Environment.Exit(0);
            }
            numOfSiblings = int.Parse(strNumOfSiblings);

            //Processing retire in year
            //Use rather user age is an even or odd number to determine when they will retire
            Console.Write(firstName + " " + lastName + " ");
            int retireInYears = 0; //variable initialization
            if (numUserAge % 2 == 0) //evaluate
            {
                //remainder is 0, age is EVEN
                retireInYears = 10; //assign
            }
            else
            {
                //if there is a remainder then age is ODD
                retireInYears = 5;
            }
            Console.Write("will retire in " + retireInYears + " years ");

            //Processing amount of money
            //Use birth month to determine amount of money
            float amountOfMoney = 0;
            if (birthMonth >= 1 && birthMonth <= 4)
            {
                amountOfMoney = 5000000;
            }
            if (birthMonth >= 5 && birthMonth <= 8)
            {
                amountOfMoney = 1000000;
            }
            if (birthMonth >= 9 && birthMonth <= 12)
            {
                amountOfMoney = 250000;
            }
            if (birthMonth < 01 && birthMonth <= 12)
            {
                amountOfMoney = 0;
            }
            Console.WriteLine("with $" + amountOfMoney + " in the bank, ");

            //Processing siblings
            //Use number of siblings to determine vacation home
            string vacationHome = ""; //initialize
            if (numOfSiblings == 0) //evaluate
            {
                vacationHome = "Hawaii"; //assign
            }
            else if (numOfSiblings == 1)
            {
                vacationHome = "Alaska";
            }
            else if (numOfSiblings == 2)
            {
                vacationHome = "Florida";
            }
            else if (numOfSiblings == 3)
            {
                vacationHome = "California";
            }
            else if (numOfSiblings > 3)
            {
                vacationHome = "Mexico";
            }
            else if (numOfSiblings < 0)
            {
                vacationHome = "Bad vacation home!";
            }
            Console.Write("a vacation home in " + vacationHome);

            //Procesisng mode of transportation   
            //User favorite color to determines mode of transportation (i.e.car, boat, plane, etc.) 
            string modeOfTransportation = ""; //variable initialization
            if (color.ToLower() == "red") //evaluate
            {
                modeOfTransportation = "Car"; //assign
            }
            else if (color.ToLower() == "orange")
            {
                modeOfTransportation = "Boat";
            }
            else if (color.ToLower() == "yellow")
            {
                modeOfTransportation = "Plane";
            }
            else if (color.ToLower() == "green")
            {
                modeOfTransportation = "Bike";
            }
            else if (color.ToLower() == "blue")
            {
                modeOfTransportation = "Motorcyle";
            }
            else if (color.ToLower() == "indigo")
            {
                modeOfTransportation = "Train";
            }
            else if (color.ToLower() == "violet")
            {
                modeOfTransportation = "Van";
            }
            Console.Write(" and a " + modeOfTransportation + ".\n\n");

        }
    }
}