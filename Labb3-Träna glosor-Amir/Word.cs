namespace ClassLibrary
{
    public class Word
    {
        public string[] Translations { get; set;  }
        public int FromLanguage { get; set;  }
        public int ToLanguage { get; set;  }
        public Word(params string[] translation)
        {
            Translations = translation;
        }
        public Word(int fromLanguage, int toLanguage, params string[] translations)
        {
            Translations = translations;
            FromLanguage = fromLanguage;
            ToLanguage = toLanguage;
        }



    }
}