using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstInstance = Singleton.GetInstance();
            var secondInstance = Singleton.GetInstance();

            Console.WriteLine("Test references equality");
            Console.WriteLine(
                $@"'First instance == Second instance'? {firstInstance == secondInstance}
            ");
        }
    }
}
