namespace AbstractFactoryDesignPattern {
    public interface IOperatingSystemFactory
    {
        IWindowsSystem WindowsSystemOperation();
        IMacSystem MacSystemOperation();
    }
}