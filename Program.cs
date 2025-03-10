namespace Strings_brown_jaylen
{
    internal class Program
    {
        static void Main(string[] args)
        {   //ask for letter and makes a varible that is the same as the answer.
            Console.WriteLine("please put one letter");  
            char myChar = Console.ReadKey().KeyChar;
            // check if one letter is enter
            bool isLetter = char.IsLetter(myChar);
            // write tells the user if it is a letter
            Console.WriteLine($"\n{myChar} is a letter: {isLetter}.");
            // ask for part of the bee movies script and makes the answer a varible
            Console.WriteLine("please put part of the bee movie script here:");
            string sentence = Console.ReadLine();
            // ask the user to enter the word bee and save what they say
            Console.WriteLine("enter thee word bee");
            string word = Console.ReadLine();
            //checks if the word is in the sentence
            bool isIn = sentence.Contains(word);
            //tells the user if the word was in the sentence
            Console.WriteLine($"{word} exists in {sentence}, {isIn}!");
        }
    }
}
