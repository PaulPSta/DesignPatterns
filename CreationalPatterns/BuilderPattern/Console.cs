namespace BuilderPattern
{
    public class Console
    {
        private readonly string _hardDrive;
        private readonly string _network;
        private readonly string _usb;
        private readonly bool _hdmi;
        private readonly bool _bluetooth;

        public Console(string hardDrive, string network, string usb, bool hdmi, bool bluetooth)
        {
            _hardDrive = hardDrive;
            _network = network;
            _usb = usb;
            _hdmi = hdmi;
            _bluetooth = bluetooth;
        }
    }
}