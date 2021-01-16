namespace AdapterPattern
{
    public class ResourceTranslationsWrapper : IResourceTranslationsWrapper
    {
        private readonly IResourceTranslations _resourceTranslations;

        public ResourceTranslationsWrapper(IResourceTranslations resourceTranslations)
        {
            _resourceTranslations = resourceTranslations;
        }

        public string GetTranslation(string lang, string key)
        {
            var translation = _resourceTranslations.GetTranslation(lang, key);

            return translation.Item2;
        }
    }
}