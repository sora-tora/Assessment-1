using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//Needed for reading in files

namespace Asessment1OOP
{
    class Analyse
    {
        //Handles the analysis of text

        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
        public List<int> analyseText(string input)
        {
            //List of integers to hold the first five measurements:
            //1. Number of sentences
            //2. Number of vowels
            //3. Number of consonants
            //4. Number of upper case letters
            //5. Number of lower case letters
            List<int> values = new List<int>();
            //Initialise all the values in the list to '0'
            for (int i = 0; i < 5; i++)
            {
                values.Add(0);
            }
            string[] tempStringArray = input.Split(".");//Splits up the sentences
            values[0] = tempStringArray.Length-1;//Gets the number of sentences
            //This calculates the number of sentences by splitting up the string by fullstops "."
            for (int i = 0; i < input.Length; i++)
            {//Unfortunately the vowels are just a very long line, there isn't much I can think of to fix this
                if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u' || input[i] == 'A' || input[i] == 'E' || input[i] == 'I' || input[i] == 'O' || input[i] == 'U')
                {
                    values[1] = values[1]+1;//Adds to count when a vowel is present
                }
                else if ((input[i] >= 'a' && input[i] <= 'z') || (input[i] >= 'A' && input[i] <= 'Z'))//Consonants are far easier, as it's just everyhing else
                {
                    values[2] = values[2]+1;//Adds to count when a consonant is present
                }
            }
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 'A' && input[i] <= 'Z')
                {
                    values[3] = values[3]+1;//Adds to count when an uppercase character is present
                }
                else if (input[i] >= 'a' && input[i] <= 'z')
                {
                    values[4] = values[4]+1;//Adds to count when a lowercase character is present
                }
            }
            return values;
        }
    }
}
