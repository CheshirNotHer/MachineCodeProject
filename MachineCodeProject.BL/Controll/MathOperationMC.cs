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
        /// <summary>
        /// Метод сложения машинных кодов.
        /// </summary>
        /// <param name="mc1">Класс с первым слогаемым.</param>
        /// <param name="mc2">Класс с вторым слогаемым.</param>
        /// <returns>Результат сложения.</returns>
        public static MachineCodeClass Add(MachineCodeClass mc1,MachineCodeClass mc2)
        {
            #region Проверка объектов
            if (mc1 == null)
                throw new ArgumentNullException("Класс не может быть равен null.",nameof(mc1));

            if (mc2 == null)
                throw new ArgumentNullException("Класс не может быть равен null.", nameof(mc2));
            #endregion

            MachineCodeClass mcRes = TranslateInCode.TranslateNumericInMachineCode(mc1.Numeric + mc2.Numeric);
            return mcRes;
            
        }

        /// <summary>
        /// Метод для вычетания машинных кодов.
        /// </summary>
        /// <param name="mc1">Класс с вычитаемм.</param>
        /// <param name="mc2">Класс вычетателя.</param>
        /// <returns>Результат вычитания.</returns>
        public static MachineCodeClass Sub(MachineCodeClass mc1, MachineCodeClass mc2)
        {
            #region Проверка объектов
            if (mc1 == null)
                throw new ArgumentNullException("Класс не может быть равен null.", nameof(mc1));

            if (mc2 == null)
                throw new ArgumentNullException("Класс не может быть равен null.", nameof(mc2));
            #endregion

            MachineCodeClass mcRes = TranslateInCode.TranslateNumericInMachineCode(mc1.Numeric - mc2.Numeric);
            return mcRes;
        }
    
        /// <summary>
        /// Метод умножения машинного кода.
        /// </summary>
        /// <param name="mc1">Класс с множимым.</param>
        /// <param name="mc2">Класс с множителем.</param>
        /// <returns>Результат Умножения.</returns>
        public static MachineCodeClass Mul(MachineCodeClass mc1, MachineCodeClass mc2)
        {
            #region Проверка объектов
            if (mc1 == null)
                throw new ArgumentNullException("Класс не может быть равен null.", nameof(mc1));

            if (mc2 == null)
                throw new ArgumentNullException("Класс не может быть равен null.", nameof(mc2));
            #endregion

            MachineCodeClass mcRes = TranslateInCode.TranslateNumericInMachineCode(mc1.Numeric * mc2.Numeric);
            return mcRes;
        }

        /// <summary>
        /// Метод для деления машинного кода.
        /// </summary>
        /// <param name="mc1">Класс с делимым.</param>
        /// <param name="mc2">Класс с делителем.</param>
        /// <returns>Результат деления.</returns>
        public static MachineCodeClass Div(MachineCodeClass mc1, MachineCodeClass mc2)
        {
            #region Проверка объектов
            if (mc1 == null)
                throw new ArgumentNullException("Класс не может быть равен null.", nameof(mc1));

            if (mc2 == null)
                throw new ArgumentNullException("Класс не может быть равен null.", nameof(mc2));

            if (mc2.Numeric == 0)
                throw new DivideByZeroException("Делить на нуль нельзя!");
            #endregion



            MachineCodeClass mcRes = TranslateInCode.TranslateNumericInMachineCode(mc1.Numeric / mc2.Numeric);
            return mcRes;
        }
    }
}
