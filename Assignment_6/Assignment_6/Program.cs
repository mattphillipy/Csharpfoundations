//Assignment #6 - Matt Phillipy
//Copy this block into your Visual Studio.
// Review and Redo this code line by line at home.  
// Place comments on each line and describe what the code is doing
using System;
namespace Assignment_6
{
    //Creating a struct
    public struct Pet
    {
        public string Name;
        public string TypeOfPet;
    }
    class Program
    {
        static void Main()
        {
            var numberOfPets = 0;  //Matt:  Using an integer to keep track of count
            var pets = new Pet[10];  //Matt:  Instatiating and declaring an array for the struct Pet; maximum 10 items
            while (true)  // never ending loop that shows user program options
            {
                Console.Write("A)dd D)elete L)ist pets:");
                var choice = Console.ReadLine();
                switch (choice)  //Matt: switch statement to execute code based on user entry A, D, or L
                {
                    case "A":
                    case "a":
                        {    //Matt: Code to read data into memory
                            Console.Write("Name :");
                            var name = Console.ReadLine();
                            Console.Write("Type of pet :");
                            var typeOfPet = Console.ReadLine();
                            // Always add the pet at the end of the array
                            pets[numberOfPets].Name = name;
                            pets[numberOfPets].TypeOfPet = typeOfPet;
                            numberOfPets++;
                            break;
                        }
                    case "D":
                    case "d":
                        {   //Matt:  Code to delete a pet from database. 
                            if (numberOfPets == 0)
                            {
                                Console.WriteLine("No pets");  //Matt:  first check to see if any items in database
                                break;
                            }
                            // Matt:  Present a list to the user using for loop
                             for (var index = 0; index < numberOfPets; index++)
                            {   
                                Console.WriteLine("{0}. {1,-10} {2}", index + 1, pets[index].Name, pets[index].TypeOfPet);
                            }
                            Console.Write("Which pet to remove (1-{0})", numberOfPets);
                            var petNumberToDelete = Console.ReadLine();
                            var indexToDelete = int.Parse(petNumberToDelete);
                            // Squish the array from index to the end
                            // Matt:  for loop to delete selection, then re-sort (shring the array)
                            for (var index = indexToDelete - 1; index < numberOfPets; index++)
                            {
                                // Just copy the pet from the next index into the current index
                                pets[index] = pets[index + 1];
                            }
                            // We have one less pet
                            numberOfPets--;
                            break;
                        }
                    case "L":
                    case "l":
                        {
                            if (numberOfPets == 0)
                            {    //Matt:  Check to see if there are any pets in the database
                                Console.WriteLine("No pets");
                            }
                            // Matt:  for loop to list the pets in the database.  Key is list only elements with data.  index < numberOfPets
                            for (int index = 0; index < numberOfPets; index++)
                            {
                                Console.WriteLine("{0}. {1,-10} {2}", index + 1, pets[index].Name, pets[index].TypeOfPet);
                            }
                            break;
                        }
                    default:
                        {    // Matt:  required in Switch statement, otherwise program will break if user enter's invalid data
                            Console.WriteLine("Invalid option [{0}]", choice);
                            break;
                        }
                }
            }
        }
    }
}