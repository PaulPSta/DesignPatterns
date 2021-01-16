namespace AdapterPattern
{
    public interface IResourceTranslationsWrapper
    {
        string GetTranslation(string lang, string key);
    }
}