using System;
namespace SolidStrategy
{
    public class Process
    {
        IBussinesLogic _bussines = null;
        public Process(IBussinesLogic bussines) => _bussines = bussines;
        public void WorkProcess(string message)
        {
            _bussines.WorkProcess(message);
        }
    }
}
