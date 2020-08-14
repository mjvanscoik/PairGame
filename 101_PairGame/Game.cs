using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _101_PairGame
{

    public class Game
    {
        public void Seed()
        {

            Player player = new Player(6, 0);
            //List of words to pull from.
            Word dog = new Word("dog", "_ _ _", 3);
            Word dinosaur = new Word("dinosaur", "_ _ _ _ _ _ _ _", 8);
            Word house = new Word("house", "_ _ _ _ _", 5);
            Word mouse = new Word("mouse", "_ _ _ _ _", 5);
            Word developer = new Word("gravel", "_ _ _ _ _ _", 5);
            List<Word> wordBank = new List<Word> { dog, dinosaur, house, mouse, developer };


            // select a word from the list randomly using the index
            var random = new Random();
            int index = random.Next(wordBank.Count);

            // retrieve the letter length of word selected randomly            
            var randomSelection = wordBank[index].LetterLength;



            // retrieve character array of the randomly selected word
            var selectionArray = wordBank[index].CharArray;

            string selectedWord = wordBank[index].WordName;
            List<string> listOfSelectedWordLetters = new List<string>();
            listOfSelectedWordLetters.AddRange(selectedWord.Select(c => c.ToString()));

          Menu(randomSelection, listOfSelectedWordLetters);




        }
        //public void NumberCruncher(char[] ca, char ch)
        //{
        //    foreach (char item in selectionArray)
        //    {

        //    }
        ////    //loop through the character array in search of user character input


        ////    // user character input comparison to characters in the array
        ////    // if character input is equal to a character in the array
        ////    if (selectionArray.Contains(userInput))
        ////    {
        ////        // went through character match gate
        ////        // reset the correctmatch int variable zero
        ////        // Add 1 to the correctmatch int variable

        ////    }
        ////    // if character input is not equal to a character in the array
        ////    else
        ////    {
        ////        // did not match character
        ////        // subtract 1 from the limbs 
        ////    }
        ////    // subtract correctmatch int variable from the total characters variable

        ////    // total characters = 0 you won
        ////    // total limbs = 0 you lost


        ////    //Console.WriteLine($"the letter {userinput} was correct. You have {totalcount} letters left.");
        //}

        
        public void Menu(string str, List<string> str1)
        {



            Console.WriteLine("Yo! Welcome to hangman! Below there should be blank lines corresponding to the number of letters in the word you're trying to guess. Guess correctly, and move to a new word. Guess incorrectly and you shall suffer a terrible fate.\n" +
                "\n" +
                "Press any key to continue:");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("The number of blank lines displayed below shows the length of the word. Guess the letters correctly to move on. Once you incorrectly guess 6 times, you lose.\n" +
             "\n" +
             "Press a single letter key to guess:"); //Insert display for wordLength
            Console.WriteLine(str);
            CaptureUserInput(str1); //str1
            

            //char userInput = ReturnGuess(charArray);

        }
        public void CaptureUserInput(List<string> str1) //List<string> loopList
        {
            string userInput = Char.ToString(Console.ReadKey().KeyChar);
            ReturnGuess(userInput, str1);

        }
        //You need to capture user input and store it in a collection or string
        //you need to check the userInputCollection against the chosen word                     strings are easier to check against than character arrays
       
        public List<string> listofGoodUserInput = new List<string>();
        public List<string> listOfBadUserInput = new List<string>();
        public void ReturnGuess(string userInput, List<string> wordLetters)

        {
          
           

            foreach (string str in wordLetters)
            {
                if (wordLetters.Contains(userInput))
                {
                    Console.Clear();
                    listofGoodUserInput.Add(userInput);
                    foreach (string i in listofGoodUserInput)
                    {
                        Console.Write($"{i}\n" +
                            $" ");
                    }
                    Console.WriteLine($"{userInput} was a letter in the word!");
                    

                    if (listofGoodUserInput.Count >= wordLetters.Count)
                    {
                        Console.Clear();
                        Console.WriteLine("You won the game!");
                        Console.ReadLine();
                    }
                    else
                    {
                       
                        Console.WriteLine(value: $"{listofGoodUserInput[0]}    Keep Guessing!");
                        CaptureUserInput(wordLetters);
                    }
                }
                else if (listOfBadUserInput.Count >= 6) 
                {
                    Console.Clear();
                    Console.WriteLine($"You lost the game!");
                    Console.ReadLine();
                } //else if
                else
                {
                    Console.Clear();
                    listOfBadUserInput.Add(userInput);
                    foreach (string i in listofGoodUserInput)
                    {
                        Console.Write($"{i}\n" +
                            $" ");
                    }
                    Console.WriteLine($"{userInput} was not a letter in the word."); //Display limbs lost
                    CaptureUserInput(wordLetters);
                }
            }

            //    }

            //    // total characters = 0 you won
            //    // total limbs = 0 you lost


            //    //Console.WriteLine($"the letter {userinput} was correct. You have {totalcount} letters left.");
            //    return userInput;

            //----
            //while (listOfBadUserInput.Count != 6)
            //{
            //    if (wordLetters.Contains(userInput))
            //    {
            //        listofGoodUserInput.Add(userInput);

            //        if (listofGoodUserInput == wordLetters)
            //        {
            //            Console.WriteLine("You won the game!");
            //        }
            //        else
            //        {

            //            CaptureUserInput(wordLetters); 
            //        }
            //    }
            //    else 
            //    { 
            //        listOfBadUserInput.Add(userInput); 
            //        CaptureUserInput(wordLetters); 
            //    }
            //} 
            //while (listOfBadUserInput.Count >= 6) { Console.WriteLine("You lost the game!"); }

            // -------------------------

        }

    }



}


