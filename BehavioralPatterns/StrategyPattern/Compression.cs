namespace StrategyPattern
{
    public class Compression
    {
        private readonly ICompressStrategy _compress;

        public Compression(ICompressStrategy compress)
        {
            _compress = compress;
        }

        public byte[] Compress(byte[] value)
        {
            return _compress.Compress(value);
        }
    }
}