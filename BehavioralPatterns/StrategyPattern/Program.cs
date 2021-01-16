using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var compressStrategy = new DefaultCompressionStrategy();
            var compression = new Compression(compressStrategy);

            var binary = new byte[] { 1, 0, 0, 1};
            Console.WriteLine($"Before compression: {BitConverter.ToString(binary)}");

            var compressed = compression.Compress(binary);
            Console.WriteLine($"After compression: {BitConverter.ToString(compressed)}");
        }
    }
}
