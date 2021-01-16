namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var light = new Light();
            var on = new TurnOnLightCommand(light);
            var off = new TurnOffLightCommand(light);
            var remote = new RemoteController(on, off);

            remote.On();
            remote.Off();
        }
    }
}
