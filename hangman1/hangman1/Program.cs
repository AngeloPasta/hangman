using System.Text.RegularExpressions;

namespace hangman
{
    internal class Program
    {
        /// <summary> //using three slashes like this generate a comment like this
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //possible words to guess
            string[] words = ["csharp", "visualstudio", "language", "array", "variable", "parsing", "constant"];
            //select a random word
            int randomNum = new Random().Next(words.Length-1);
            string wordToGuess = words[randomNum];

            //list of acceptable aprameters, to verify player input is within A-Z.
            var validChars = new Regex("^[a-z]$");

            //List of already tried letters
            List<char> guesses = new();

            //preparation for the game: what the user sees (their guesses) and number of lives left.
            string currentFound = generateEmptyWord(wordToGuess.Length);
            int lives = 3;

            bool isFound = false;
            while (isFound != true)
            {
                Console.WriteLine("\nWord: " + currentFound);
                Console.WriteLine("\nChoose a letter: ");
                string input = Console.ReadLine();
                //ToDo: check if input is correct
            }

            Console.WriteLine(wordToGuess);
            Console.WriteLine(currentFound);
        }

        public static string generateEmptyWord(int length)
        {
            string currentFound = "";
            for (int i = 0; i < length; i++)
            {
                currentFound += "_";
            }
            return currentFound;
        }
    }
}

/* NOTES:
long myLongVar = long.MaxValue;
int myIntVar = (int)myLongVar;
Console.WriteLine(myIntVar);
---

//Utilizzo di checked che chiama un'exception se viene fatta una conversione impossibile
checked
{
    int n = int.MaxValue;
    n = n + 1;
    Console.WriteLine(n);
}
---

string textToNum = "pippo";
var convertedText = int.Parse(textToNum); //parse raises an Exception if it cannot be converted. Try to use TryParse() if you're not sure if conversion can be done.
                                          //bool result = int.TryParse(textToNum, out int convertedText); 
Console.WriteLine(convertedText);
---

int? numeroNullabile = null;
if (numeroNullabile.HasValue) //can also use [==; !=; is null; is not null]
{
    Console.WriteLine($"il valore è: {numeroNullabile.Value}");
}
---

string filename = GetfileName() ?? "config.json"; //if GetFileName doesn't find anything, it uses "config.json". Can also be chained, placing another function and another set
                                                  // value at the end.
---

Console.WriteLine(); //no need to write System.Console if we write "using System" at the top or <ImplicitUsings> is set to "enable" (see Edit Project File in hangman1)
---


*/