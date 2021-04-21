using MachineCodeProject.BL.Model;
using MachineCodeProject.BL.Controll;

using System;

namespace MachineCodeProject.CMD
{
    class Program
    {
        static void Main(string[] args)
        {
           
            try
            {
                for (;;)
                {


                    Console.Write("Enter numeric1: ");
                    MachineCodeClass mc1 = TranslateInCode.TranslateNumericInMachineCode(int.Parse(Console.ReadLine()));
                    Console.Write("Enter numeric2: ");
                    MachineCodeClass mc2 = TranslateInCode.TranslateNumericInMachineCode(int.Parse(Console.ReadLine()));
                    MachineCodeClass mcRes = mc1 + mc2;
                    Console.WriteLine($"{mcRes.ToString()}");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"{ex.Message}");
            }
          
        }
    }
}
