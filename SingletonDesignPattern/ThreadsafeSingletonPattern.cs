using System;
using System.Threading;

namespace SingletonDesignPattern
{
    public sealed class ThreadsafeSingletonPattern
    {
        private static ThreadsafeSingletonPattern _instance;
        private static readonly object _lock = new object();

        // Private constructor to prevent instance creation from outside
        private ThreadsafeSingletonPattern() { }

        // Public static method to get the instance of the class
        public static ThreadsafeSingletonPattern GetInstance()
        {
            if (_instance == null)
            {
                // Locking to ensure that only one thread can access this block at a time
                lock (_lock)
                {
                    //Once the thread is released from the lock, it checks again if the instance is still null
                    if (_instance == null)
                    {
                        _instance = new ThreadsafeSingletonPattern();
                    }
                }
            }
            return _instance;
        }
    }
}