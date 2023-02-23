using ClassLibrary;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;


void List()
{ 
    foreach (string list in WordList.GetLists())
    {
        Console.WriteLine(list);
    }
}

void Count(string listName)
{
    WordList wordlist  =  WordList.LoadList(listName);
    Console.WriteLine(wordlist.Count());
}
 


void Add(string listName)
{
    WordList wordlist = WordList.LoadList(listName);
    bool Done = false;
    do
    {

        List<string> translations = new List<string>();


        foreach (string Language in wordlist.Languages)
        {
            Console.WriteLine($"Skriv in ordet på {Language}");
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Done = true;
                break;
            }else
            {
                translations.Add(input); 
            }
        }
        if (!Done)
        {
            wordlist.Add(translations.ToArray());
        }

    } while (!Done);
    wordlist.Save();

    Console.WriteLine("Lagt till orden till listan");

}

void New(string name, string[] languages)
{ 
    WordList wordList = new WordList(name, languages);
    wordList.Save();
    Add(name);
}

void Remove(string name, string language, string[] words)
{
    WordList wordList = WordList.LoadList(name);
    int languageId = Array.IndexOf(wordList.Languages, language);
    foreach (string word in words)
    {
        wordList.Remove(languageId, word); 
    }
    wordList.Save();
}


void Words(string Listname, string SortByLaguage )
{
    WordList wordList = WordList.LoadList(Listname);
    int sortByLanguage = Array.IndexOf(wordList.Languages, SortByLaguage);
    wordList.List(sortByLanguage, translations => {
        Console.WriteLine(string.Join(", ", translations));
    });
}



void Practice (string listname)
{
    WordList wordList = WordList.LoadList(listname);
    int Correct = 0;
    int Total = 0; 
    do
    {
        Word word = wordList.GetWordToPractice();
        Console.WriteLine($"Översätt det {wordList.Languages[word.FromLanguage]} ordet {word.Translations[word.FromLanguage]} till {wordList.Languages[word.ToLanguage]}");
        string input = Console.ReadLine();
        if(string.IsNullOrEmpty(input))
        {
            break;
        }
        else
        {
            string CorrectWord = word.Translations[word.ToLanguage].ToLower();
            if (input.ToLower() == CorrectWord) 
            {
                Console.WriteLine("Du hade rätt");
                Correct++; 
            }
            else
            {
                Console.WriteLine($"du hade fel ordet var {CorrectWord}");
            }
            Total++;
        }
    } 
    while (true);
    Console.WriteLine($"Du tränade på {Total} ord av dessa var {Correct} rätt. Det är {(Correct / (float)Total * 100):f0}% rätt ");

}


void start()
{
    if(args.Length == 0)
    {
        PrintMenu();
    }
    else
    {
        try
        {


            switch (args[0].ToLower())
            {
                case "-lists":
                    List();
                    break;
                case "-new":
                    New(args[1], args[2..]);
                    break;
                case "-add":
                    Add(args[1]);
                    break;
                case "-remove":
                    Remove(args[1], args[2], args[3..]);
                    break;
                case "-words":
                    Words(args[1], args[2]);
                    break;
                case "-count":
                    Count(args[1]);
                    break;
                case "-practice":
                    Practice(args[1]);
                    break;

                default:
                    PrintMenu();
                    break;

            }
        }
        catch
        {
            PrintMenu();
        }
    }
}
start();

void PrintMenu()
{
    Console.WriteLine("Use any of the following parameters:");
    Console.WriteLine("-lists");
    Console.WriteLine("-new <list name> <language 1> <language 2> .. <langauge n>");
    Console.WriteLine("-add <list name>");
    Console.WriteLine("-remove <list name> <language> <word 1> <word 2> .. <word n>");
    Console.WriteLine("-words <listname> <sortByLanguage>");
    Console.WriteLine("-count <listname>");
    Console.WriteLine("-practice <listname>");
}

