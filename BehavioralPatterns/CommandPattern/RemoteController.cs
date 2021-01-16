namespace CommandPattern
{
    public class RemoteController
    {
        private readonly ICommand _on;
        private readonly ICommand _off;

        public RemoteController(ICommand on, ICommand off)
        {
            _on = on;
            _off = off;
        }

        public void On()
        {
            _on.Execute();
        }

        public void Off()
        {
            _off.Execute();
        }
    }
}