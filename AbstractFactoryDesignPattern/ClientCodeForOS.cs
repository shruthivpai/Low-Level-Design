namespace AbstractFactoryDesignPattern
{
    public class ClientCodeForOS
    {
        private readonly IOperatingSystemFactory _operatingSystemFactory;

        public ClientCodeForOS(IOperatingSystemFactory operatingSystemFactory)
        {
            _operatingSystemFactory = operatingSystemFactory;
        }

        public void Execute()
        {
            var windowsSystem = _operatingSystemFactory.WindowsSystemOperation();
            windowsSystem.Button();
            windowsSystem.Menu();

            var macSystem = _operatingSystemFactory.MacSystemOperation();
            macSystem.Button();
            macSystem.Menu();
            macSystem.Display();
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            IOperatingSystemFactory factory1 = new OperatingSystemFactory1();
            ClientCodeForOS client = new ClientCodeForOS(factory1);
            client.Execute();
        }
    }
}