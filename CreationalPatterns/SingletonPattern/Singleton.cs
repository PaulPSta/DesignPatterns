namespace SingletonPattern
{
    public class Singleton
    {
        private static Singleton _singleton;

        private Singleton() { }

        public static Singleton GetInstance() => _singleton ??= new Singleton();
    }
}