using System;
namespace SolidStrategy
{
    public class Crm : IBussinesLogic
    {
        public void WorkProcess(string message)
        {
            Console.WriteLine($"Process Crm! :{message}");
        }
    }
}
