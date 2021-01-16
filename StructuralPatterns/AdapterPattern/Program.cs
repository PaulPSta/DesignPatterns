using System;
using System.Collections.Generic;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<(string, string), string>
            {
                {("EN", "Adapter pattern"), "One of the software design patterns, also known as a wrapper."}
            };
            var translations = new ResourceTranslations(dict);
            IResourceTranslationsWrapper translationsWrapper = new ResourceTranslationsWrapper(translations);

            const string langCode = "EN";
            const string searchPhrase = "Adapter pattern";

            var translation = translationsWrapper.GetTranslation(langCode, searchPhrase);
            Console.WriteLine($"{searchPhrase}:{translation}");

            //var (key, translation) = translations.GetTranslation(langCode, searchPhrase);
            //Console.WriteLine($"{key}:{translation}");
        }
    }
}