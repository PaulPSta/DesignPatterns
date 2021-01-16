namespace BuilderPattern
{
    public class ConsoleBuilder
    {
        private string _hardDrive;
        private string _network;
        private string _usb;
        private bool _hdmi;
        private bool _bluetooth;

        public ConsoleBuilder WithHardDrive(string hardDrive)
        {
            _hardDrive = hardDrive;

            return this;
        }

        public ConsoleBuilder WithNetwork(string network)
        {
            _network = network;

            return this;
        }

        public ConsoleBuilder WithUsb(string usb)
        {
            _usb = usb;

            return this;
        }

        public ConsoleBuilder WithHdmi()
        {
            _hdmi = true;

            return this;
        }

        public ConsoleBuilder WithBluetooth()
        {
            _bluetooth = true;

            return this;
        }

        public Console Build() => new Console(_hardDrive, _network, _usb, _hdmi, _bluetooth);
    }
}