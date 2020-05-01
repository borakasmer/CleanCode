using System;
namespace SolidStrategy
{
    public class Service : IBussinesLogic
    {
        public void WorkProcess(string message)
        {
            Console.WriteLine($"Process Service! :{message}");
        }
    }
}
