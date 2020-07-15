using System;
using System.Collections.Generic;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dictionary<string, int> toysSold = new Dictionary<string, int>() {
            // {"Hot Wheels", 344},
            // {"Legos", 763},
            // {"Gaming Consoles", 551},
            // {"Board Games", 298}
            // };

            // toysSold.Add("Bicycles", 87);

            // foreach(KeyValuePair<string, int> toy in toysSold)
            // {
            //     Console.WriteLine($"We sold {toy.Value} units of {toy.Key}");
            // }

            //Exercise 1: Dictionary of Words
            // /*
            //     Create a dictionary with key value pairs to
            //     represent words (key) and its definition (value)
            // */
            // Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

            // // Add several more words and their definitions
            // wordsAndDefinitions.Add("Awesome", "the feeling of students when they are learning C#");
            // wordsAndDefinitions.Add("Sonder", "the realization that each passerby has a life as vivid and complex as your own.");
            // wordsAndDefinitions.Add("Opia", "the ambiguous intensity of looking someone in the eye which can feel simultaneously invasive and vulnerable.");
            // wordsAndDefinitions.Add("Enouement", "the bittersweetness of having arrived in the future, seeing how things turn out, but not being able to tell your past self.");
            // wordsAndDefinitions.Add("Vellichor", "the strange wistfulness of used bookshops.");
            // wordsAndDefinitions.Add("Monachopsis", "the subtle but persistent feeling of being out of place.");
            // wordsAndDefinitions.Add("Kenopsia", "the eerie, forlorn atmosphere of a place that is usually bustling with people but is now abandoned and quiet.");

            // /*
            //     Use square brackets to get the definition of two of the
            //     words and then output them to the console
            // */
            // string definitionOfKenopsia = wordsAndDefinitions["Kenopsia"];
            // string definitionOfSonder = wordsAndDefinitions["Sonder"];
            // Console.WriteLine(definitionOfKenopsia);
            // Console.WriteLine(definitionOfSonder);
            // /*
            //     Below, loop over the wordsAndDefinitions dictionary to get the following output:
            //         The definition of (WORD) is (DEFINITION)
            //         The definition of (WORD) is (DEFINITION)
            //         The definition of (WORD) is (DEFINITION)
            // */
            // foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            // {
            //     Console.WriteLine($"The definition of {word.Key} is {word.Value}");
            // }

            //Exercise 2: List of Dictionaries about Words
            // Make a new list
            // List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();

            // /*
            //     You want to track the following about each word:
            //         word, definition, part of speech, example sentence

            //     Example of one dictionary in the list:
            //     {
            //         "word": "excited",
            //         "definition": "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness",
            //         "part of speech": "adjective",
            //         "example sentence": "I am excited to learn C#!"
            //     }
            // */

            // // Create dictionary to represent a few words
            // Dictionary<string, string> excitedWord = new Dictionary<string, string>();

            // // Add each of the 4 bits of data about the word to the Dictionary
            // excitedWord.Add("word", "excited");
            // excitedWord.Add("definition", "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness");
            // excitedWord.Add("part of speech", "adjective");
            // excitedWord.Add("example sentence", "I am excited to learn C#!");

            // // Add Dictionary to your `dictionaryOfWords` list
            // dictionaryOfWords.Add(excitedWord);

            // // create another Dictionary and add that to the list
            // Dictionary<string, string> sonderWord = new Dictionary<string, string>();

            // // Add each of the 4 bits of data about the word to the Dictionary
            // sonderWord.Add("word", "sonder");
            // sonderWord.Add("definition", "the realization that each passerby has a life as vivid and complex as your own");
            // sonderWord.Add("part of speech", "noun");
            // sonderWord.Add("example sentence", "I am struck by a moment of sonder as I code in C#.");

            // dictionaryOfWords.Add(sonderWord);

            // /*
            //     Iterate your list of dictionaries and output the data, You can use the two foreach() loops below to help you start your iteration.

            //     Example output for one word in the list of dictionaries:
            //         word: excited
            //         definition: having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness
            //         part of speech: adjective
            //         example sentence: I am excited to learn C#!
            // */

            // // Iterate the List of Dictionaries
            // foreach (Dictionary<string, string> words in dictionaryOfWords)
            // {
            //     Console.WriteLine("\n");
            //     // Iterate the KeyValuePairs of the Dictionary
            //     foreach (KeyValuePair<string, string> wordData in words)
            //     {
            //         Console.WriteLine($"{wordData.Key}: {wordData.Value}");
            //     }
            // }

            //Exercise 3: English Idioms
            // Dictionary<string, List<string>> idioms = new Dictionary<string, List<string>>();
            // idioms.Add("Penny", new List<string> { "A", "penny", "for", "your", "thoughts" });
            // idioms.Add("Injury", new List<string> { "Add", "insult", "to", "injury" });
            // idioms.Add("Moon", new List<string> { "Once", "in", "a", "blue", "moon" });
            // idioms.Add("Grape", new List<string> { "I", "heard", "it", "through", "the", "grapevine" });
            // idioms.Add("Murder", new List<string> { "Kill", "two", "birds", "with", "one", "stone" });
            // idioms.Add("Limbs", new List<string> { "It", "costs", "an", "arm", "and", "a", "leg" });
            // idioms.Add("Grain", new List<string> { "Take","what","someone","says","with","a","grain","of","salt" });
            // idioms.Add("Fences", new List<string> { "I'm", "on", "the", "fence", "about", "it" });
            // idioms.Add("Sheep", new List<string> { "Pulled", "the", "wool", "over", "his", "eyes" });
            // idioms.Add("Lucifer", new List<string> { "Speak", "of", "the", "devil" });

            // foreach (KeyValuePair<string, List<string>> idiom in idioms)
            // {
            //     Console.WriteLine($"{idiom.Key}: "+ String.Join(" ", idiom.Value));
            // }

            //Challenge: Randall's Car Lot in C#
            // "vehicles": [
            //     {
            //         "vehicle": {
            //             "year": "2008",
            //             "model": "Damfresh",
            //             "make": "Biotraxquote",
            //             "color": "sky magenta"
            //         },
            //         "sales_agent": {
            //             "mobile": "(896) 478-6975",
            //             "last_name": "Botsford",
            //             "first_name": "Shaina"
            //         },
            //         "credit": {
            //             "credit_provider": "J.P.Morgan Chase & Co",
            //             "account": "601109582720302"
            //         }
            //     },
            //     {
            //         "vehicle": {
            //             "year": "2010",
            //             "model": "Hotquadtrax",
            //             "make": "Transtintechno",
            //             "color": "robin egg blue"
            //         },
            //         "sales_agent": {
            //             "mobile": "562.300.2912",
            //             "last_name": "Davis",
            //             "first_name": "Gerardo"
            //         },
            //         "credit": {
            //             "credit_provider": "PNC Financial Services",
            //             "account": "34578280562836"
            //         }
            //     }
            // ]
            // Dictionary<string, List<Dictionary <Dictionary <string, Dictionary<string, string>>>>
            // listOfVehicles = new Dictionary<string, List<Dictionary <Dictionary<string, Dictionary<string, string>>>>();

            // Challenge: The Family Dictionary
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("sister", new Dictionary<string, string>(){
                {"name", "Krista"},
                {"age", "42"}
            });
            
            foreach(KeyValuePair<string, Dictionary<string, string>> familyMember in myFamily)
            {
                foreach (KeyValuePair<string, string> memberData in familyMember.Value)
                {
                    Console.WriteLine(memberData.Value);
                    foreach (char data in memberData.Value){
                        Console.WriteLine($"{data} is my {familyMember.Key} and is {memberData.Value}");
                    }
                }
            }
        }
    }
}
