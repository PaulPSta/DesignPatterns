namespace AdapterPattern
{
    public interface IResourceTranslations
    {
        (string, string) GetTranslation(string lang, string key);
    }
}