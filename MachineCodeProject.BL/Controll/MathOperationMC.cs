using MachineCodeProject.BL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MachineCodeProject.BL.Controll
{
    /// <summary>
    /// Класс для решения математических операция над машинным кодом. ИСПРАВЛЯТЬ ЛИ? НО РЕШЕНИЯ ПРОИСХОДЯТ ТОЛЬКО ЧЕРЕЗ ЧИЛА.
    /// </summary>
    public class MathOperationMC
    {
        //TODO:Сделать перегрузку операторов в классе MachineCodeClass
       
        public static MachineCodeClass Add(MachineCodeClass mc1,MachineCodeClass mc2)
        {
          
            TranslateInCode tc = new TranslateInCode();
            MachineCodeClass mcRes = tc.TranslateNumericInMachineCode(mc1.Numeric + mc2.Numeric);
            return mcRes;
            
        }

        public MachineCodeClass Add()
        {
            throw new NotImplementedException();
        }

        public static MachineCodeClass Sub(MachineCodeClass mc1, MachineCodeClass mc2)
        {
            TranslateInCode tc = new TranslateInCode();
            MachineCodeClass mcRes = tc.TranslateNumericInMachineCode(mc1.Numeric - mc2.Numeric);
            return mcRes;
        }
    
        public static MachineCodeClass Mul(MachineCodeClass mc1, MachineCodeClass mc2)
        {
            TranslateInCode tc = new TranslateInCode();
            MachineCodeClass mcRes = tc.TranslateNumericInMachineCode(mc1.Numeric * mc2.Numeric);
            return mcRes;
        }

        public static MachineCodeClass Div(MachineCodeClass mc1, MachineCodeClass mc2)
        {
            if (mc2.Numeric == 0)
                throw new DivideByZeroException("Делить на нуль нельзя!");

            TranslateInCode tc = new TranslateInCode();
            MachineCodeClass mcRes = tc.TranslateNumericInMachineCode(mc1.Numeric / mc2.Numeric);
            return mcRes;
        }
    }
}
