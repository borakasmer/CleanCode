using System;
namespace SolidStrategy
{
    public class Finance : IBussinesLogic
    {
        public void WorkProcess(string message)
        {
            Console.WriteLine($"Process Finance! :{message}");
        }
    }
}
