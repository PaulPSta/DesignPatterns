using System.Collections.Generic;

namespace AdapterPattern
{
    public class ResourceTranslations : IResourceTranslations
    {
        private readonly Dictionary<(string, string), string> _translations;

        public ResourceTranslations(Dictionary<(string, string), string> translations)
        {
            _translations = translations;
        }

        public (string, string) GetTranslation(string lang, string key)
        {
            _translations.TryGetValue((lang, key), out var translation);

            return (key, translation);
        }
    }
}