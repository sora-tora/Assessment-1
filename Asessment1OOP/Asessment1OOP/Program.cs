using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//Needed for reading in files

namespace Asessment1OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean check = true;//This is merely for my while loop menu system, so that a user can use my programming as many times as they want, without having to exit the program
            Boolean check2 = true;//This is for the second menu
            string choice = "";//This is for the users choice in the menu system, allowing the user a choice in what they choose to do.
            string choice2 = "";//I made a second choice string so to not interfere with the greater menu loop, as if I used the same variable, you may be put into a loop that you did not want to choose
            string programText = "";
            string filename = @"C:\Users\zolin\Documents\University\2021-2022\CMP1903M-1-2021_Object-Oriented Programming_2022\Assessment1\Asessment1OOP\Asessment1OOP\testTextFile.txt";//This is a variable used for storing the filename

            //Local list of integers to hold the first five measurements of the text
            List<int> parameters = new List<int>();

            //Create 'Input' object
            //Get either manually entered text, or text from a file
            Input input = new Input();


            //Create an 'Analyse' object
            //Pass the text input to the 'analyseText' method
            Analyse analyse = new Analyse();


            //Receive a list of integers back


            //Report the results of the analysis


            //TO ADD: Get the frequency of individual letters?
            //Added
            while(check)//Menu system
            {//I added a additional choice of "quiting" to better communicate with the user
                Console.WriteLine("PLEASE SELECT A FOLLOWING CHOICE:\n1)DO YOU WANT TO ENTER TEXT VIA THE KEYBOARD?\n2)DO YOU WANT TO READ IN THE TEXT VIA A FILE?\n3)EXIT MENU");
                choice = Console.ReadLine();
                if(choice == "1")
                {
                    programText = input.manualTextInput();
                    parameters = analyse.analyseText(programText);
                    Console.WriteLine(parameters[1]);
                    //Inititially I was going to have a for loop print out the values, but because of the scale of this project
                    //and the need to display what values are recorded, I just manually printed them out
                    Console.WriteLine("NUMBER OF SENTENCES ENTERED="+parameters[0]+"\nNUMBER OF CHARACTERS="+(parameters[3]+parameters[4])+"\nNUMBER OF VOWELS="+parameters[1]+"\nNUMBER OF CONSONANTS="+parameters[2]+"\nNUMBER OF UPPERCASE CHARACTERS="+parameters[3]+"\nNUMBER OF LOWERCASE CHARACTERS="+parameters[4]);
                    check2 = true;
                    while(check2)
                    {
                        Console.WriteLine("DO YOU WISH TO COUNT THE NUMBER OF AN INDIVIDUAL LETTER?\nPLEASE SELECT A FOLLOWING CHOICE:\n1)YES\n2)NO");//I could have included this in the previous write line, but this looks neater to read
                        choice2 = Console.ReadLine();
                        if(choice2 == "1")
                        {
                            individualCharacterCount(programText);
                            check2 = false;
                        }
                        else if(choice2 == "2")
                        {
                            check2 = false;
                        }
                        else
                        {
                            Console.WriteLine("INCORRECT INPUT, TRY AGAIN");//While not a true error handlinging, this accounts for a user's incorrect input and gives out an error message
                        }
                    }
                }
                //Given that printing out the values is just one lie, I didn't feel the need to make it a method
                else if (choice == "2")
                {
                    //filename = Console.ReadLine();
                    programText = input.fileTextInput(filename);
                    parameters = analyse.analyseText(programText);
                    //Inititially I was going to have a for loop print out the values, but because of the scale of this project
                    //and the need to display what values are recorded, I just manually printed them out
                    Console.WriteLine("NUMBER OF SENTENCES ENTERED=" + parameters[0] + "\nNUMBER OF VOWELS=" + parameters[1] + "\nNUMBER OF CONSONANTS=" + parameters[2] + "\nNUMBER OF UPPERCASE CHARACTERS=" + parameters[3] + "\nNUMBER OF LOWERCASE CHARACTERS=" + parameters[4]);
                    check2 = true;
                    while (check2)
                    {
                        Console.WriteLine("DO YOU WISH TO COUNT THE NUMBER OF AN INDIVIDUAL LETTER?\nPLEASE SELECT A FOLLOWING CHOICE:\n1)YES\n2)NO");//I could have included this in the previous write line, but this looks neater to read
                        choice2 = Console.ReadLine();
                        if (choice2 == "1")
                        {
                            individualCharacterCount(programText);
                            check2 = false;
                        }
                        else if (choice2 == "2")
                        {
                            check2 = false;
                        }
                        else
                        {
                            Console.WriteLine("INCORRECT INPUT, TRY AGAIN");//While not a true error handlinging, this accounts for a user's incorrect input and gives out an error message
                        }
                    }
                }
                else if (choice == "3")
                {
                    Console.WriteLine("EXITING MENU");//Lets user know that they are exiting the menu
                    check = false;
                }
                else
                {
                    Console.WriteLine("INCORRECT INPUT, TRY AGAIN");//While not a true error handlinging, this accounts for a user's incorrect input and gives out an error message
                }
            }

            int individualCharacterCount(string input)//This method helps find the instance of an individual character in 
            {
                int count = 0;
                Console.WriteLine("PLEASE ENTER THE CHARACTER THAT YOU WISH TO COUNT");
                string select = Console.ReadLine();
                select = select[0].ToString();//We only need the first character, this is impromtu error handling, so if a user enters more that one character, everything but the first will be ignored
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i].ToString() == select.ToUpper() || input[i].ToString() == select.ToLower())//Checks if elements in string match the selected character, regardless of case
                    {
                        count = count+1;
                    }
                }
                Console.WriteLine("NUMBER OF '"+select+"' ENTERED="+count);
                return count;
            }
        }
    }
}
