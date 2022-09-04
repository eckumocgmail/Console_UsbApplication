using System;
using System.Threading;

namespace Console_UseApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var manager = new USBManager();
            manager.Init();
            Thread.Sleep(Timeout.Infinite);
        }
    }
}
