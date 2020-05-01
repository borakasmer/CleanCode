using System;

namespace SolidStrategy
{
    public enum ProcessType
    {
        Finance,
        Service,
        Crm
    }

    class Program
    {
        static void Main(string[] args)
        {
            //ProcessCalculation(ProcessType.Crm);

            Process process = new Process(new Crm());
            process.WorkProcess("Update Crm DB");
        }

        //public static void ProcessCalculation(ProcessType type)
        //{
        //    try
        //    {
        //        if (type == ProcessType.Crm)
        //        {
        //            CallCrm("Update Crm DB");
        //        }
        //        else if (type == ProcessType.Finance)
        //        {
        //            CallFinance("Send Mail to Customers");
        //        }
        //        else if (type == ProcessType.Service)
        //        {
        //            CallService("Backup all Data");
        //        }
        //    }
        //    catch
        //    {

        //    }
        //}

        //public static void CallCrm(string message) { Console.WriteLine($"Process Crm! :{message}"); }
        //public static void CallFinance(string message) { Console.WriteLine($"Process Finance! :{message}"); }
        //public static void CallService(string message) { Console.WriteLine($"Process Service! :{message}"); }
    }
}
