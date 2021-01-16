using System.Linq;

namespace StrategyPattern
{
    public class DefaultCompressionStrategy : ICompressStrategy
    {
        public byte[] Compress(byte[] value)
        {
            return value.Where((x, idx) => idx % 2 == 0).ToArray();
        }
    }
}