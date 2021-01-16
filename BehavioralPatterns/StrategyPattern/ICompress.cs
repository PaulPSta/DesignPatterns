namespace StrategyPattern
{
    public interface ICompressStrategy
    {
        public byte[] Compress(byte[] value);
    }
}