using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibrary
{
    public class WordList
    {
        private List<Word> _words;
        public string Name { get; set; }
        public string[] Languages { get; set;  }

        static string WordListPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Lab3");

         

        public WordList(string name, params string[] languages)
        {
            Name = name;
            Languages = languages;
            _words = new List<Word>();
        }

        public static string[] GetLists()
        {
            string[] files = Directory.GetFiles(WordListPath, "*.dat");
            for (int i = 0; i < files.Length; i++)
            {
                files[i] = Path.GetFileNameWithoutExtension(files[i]);

            }
            return files;   
        }
        
        public static WordList LoadList(string name)
        {
            string filename = @$"{WordListPath}\{name}.dat";
            using (StreamReader reader = new StreamReader(filename)) 
            {
                string line = reader.ReadLine();
                string[] languages = line.Split(";", StringSplitOptions.RemoveEmptyEntries);
                WordList list = new WordList(name, languages);
                while (!reader.EndOfStream) 
                {
                    line = reader.ReadLine();
                    string[] translations = line.Split(";", StringSplitOptions.RemoveEmptyEntries);
                    Word word = new Word(translations);
                    list._words.Add(word);  
                }
                return list;
            }
        }

        public void Save()
        {
            string fileName = @$"{WordListPath}\{Name}.dat";
            using (StreamWriter writer = new StreamWriter(fileName)) 
            {
                writer.WriteLine(string.Join(";", Languages));
                foreach (Word word in _words)
                {
                    string line = string.Join(";", word.Translations);
                    writer.WriteLine(line);
                }
            }
        }
        public void Add(params string[] translations)
        {
            if (translations.Length != Languages.Length)
            {
                throw new ArgumentException("Incorrect number of translations");

            }
            Word word = new Word(translations);
            _words.Add(word);
        }
        public bool Remove(int translation, string word)
        {
            for (int i = 0; i < _words.Count; i++) 
            {
                if (_words[i].Translations[translation] == word)    
                { 
                _words.RemoveAt(i);
                return true;
                }

            }
            return false;
        }
        public  int Count()
        {
            return _words.Count;    
        }
        public void List(int sortByTranslation, Action<string[]> showTranslations)
        {
            _words = _words.OrderBy(w => w.Translations[sortByTranslation]).ToList();   

            foreach (Word word in _words)
            {
                showTranslations(word.Translations);
            }
        }
        public Word GetWordToPractice()
        {
            int index = new Random().Next(_words.Count);
            var word = _words[index];
            Random rnd = new Random();
            int fromLanguage = rnd.Next(0, Languages.Length);
            int toLanguage = rnd.Next(0, Languages.Length);
            while (fromLanguage == toLanguage)
            {
                toLanguage = rnd.Next(0, Languages.Length);
            }
            word.FromLanguage = fromLanguage;
            word.ToLanguage = toLanguage;
            return word;
        }


    }
}
