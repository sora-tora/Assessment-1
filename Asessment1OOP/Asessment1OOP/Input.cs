using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//Needed for reading in files
namespace Asessment1OOP
{
    class Input
    {
        //Handles the text input for Assessment 1
        string text = "nothing";//Anything can go here really

        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        public string manualTextInput()
        {
            Console.WriteLine("PLEASE ENTER ONE OR MORE SENTENCES, INDICATING THE END OF YOUR ENTRY WITH AN ASTERISK (*) :");
            text = Console.ReadLine();//Console.ReadLine() allows user to input text into the program
            string[] tempArray = text.Split("*");//Splits string into substrings on asterisks
            text = tempArray.ElementAt(0);//We just need the first element, as the end of an input is indicated by an asterisk, so anything afterwards is irrelevant
            return text;
        }

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        public string fileTextInput(string fileName)//This method gets not just the text from the file, but also gets the desired part
        {
            text = File.ReadAllText(fileName);//Reads all text from file and writes that to the string text
            string[] tempArray = text.Split("*");//Splits string into substrings on asterisks
            //List<string> allText = tempArray.ToList();//Converts split array into list, wait, I don't need this
            text = tempArray.ElementAt(0);//We just need the first element, as the end of an input is indicated by an asterisk, so anything afterwards is irrelevant
            return text;
        }
    }
}
