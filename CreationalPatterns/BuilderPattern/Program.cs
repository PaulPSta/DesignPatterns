namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var consoleBuilder = new ConsoleBuilder();
            var console = consoleBuilder
                .WithHardDrive("512 GB")
                .WithNetwork("802.11ac")
                .WithUsb("USB 3.1")
                .WithHdmi()
                .Build();
        }
    }
}