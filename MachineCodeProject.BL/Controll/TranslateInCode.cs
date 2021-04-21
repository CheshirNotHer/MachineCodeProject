using MachineCodeProject.BL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MachineCodeProject.BL.Controll
{
    public class TranslateInCode
    {
        
        /// <summary>
        /// Перевод числа в прямой, обратный и дополнительный код.
        /// </summary>
        /// <param name="num">Число, в десятеричной СС, для перевода в прямой, обратный и дополнительный код.</param>
        /// <returns></returns>
        public static MachineCodeClass TranslateNumericInMachineCode(int num)
        {
            MachineCodeClass mc = new MachineCodeClass(num);
            TranslateInStraightCode(mc);
            TransateInReversCode(mc);
            TranslateInAdditionalCode(mc);
            return mc;
        }

        /// <summary>
        /// Перевод числа в прямой код.
        /// </summary>
        /// <param name="mc">Класс с числом которое необходимо перевести и для хранения результата.</param>
        private static void TranslateInStraightCode(MachineCodeClass mc)
        {
            if (mc == null)
                throw new ArgumentNullException("Класс не может быть равенн null.",nameof(mc));

            mc.StraightCode = $"{mc.sign.ToString()}:{Convert.ToString(Math.Abs(mc.Numeric), 2)} ";
        }

        /// <summary>
        /// Перевод в обратный код.
        /// </summary>
        /// <param name="mc">Класс с числом которое необходимо перевести и заполненным прямым кодом, и для хранения результата.</param>
        private static void TransateInReversCode(MachineCodeClass mc)
        {
            #region Проверки на ошибки
            if (mc == null)
                throw new ArgumentNullException("Класс не может быть равенн null.", nameof(mc));

            if (string.IsNullOrWhiteSpace(mc.StraightCode))
                throw new ArgumentException("Значение прямого кода не может быть пустым или равно null.",nameof(mc.StraightCode));
            #endregion

            //TODO: При положительном числе обратный код должен быть равен прямому коду
            if (mc.sign == 0)
            {
                mc.ReversCode = mc.StraightCode;
                return;
            }
            StringBuilder reverse_code = new StringBuilder($"{mc.sign}:",32);
       
            for (int i = 2; i < mc.StraightCode.Length-1; i++)
            {
                reverse_code.Append((mc.StraightCode[i] == '0') ? "1" : "0");
            }

            mc.ReversCode = reverse_code.ToString();
        }

        /// <summary>
        /// Перевод в дополнительный код.
        /// </summary>
        /// <param name="mc">Класс с числом которое необходимо перевести и заполненным обратным кодом, и для хранения результата.</param>
        private static void TranslateInAdditionalCode(MachineCodeClass mc)
        {
            #region Проверки на ошибки
            if (mc == null)
                throw new ArgumentNullException("Класс не может быть равенн null.", nameof(mc));

            if (string.IsNullOrWhiteSpace(mc.ReversCode))
                throw new ArgumentException("Обратный код неможет быть пустым или равен null.",nameof(mc.ReversCode));
            #endregion


            //TODO: При положительном числе дополнительный код должен быть равен прямому коду
            if (mc.sign == 0)
            {
                mc.AdditionalCode = mc.ReversCode;
                return;
            }

            string reverse_value = mc.ReversCode.Remove(0, 2);
            int value = Convert.ToInt32(reverse_value, 2);
            value++;
            string additCode = Convert.ToString(value, 2);
            if (reverse_value.Length == additCode.Length)
                mc.AdditionalCode = $"{mc.sign}:{additCode}";
            else
            {
                /*TODO: Если количество чисел у обратного и дополнительного кода не совпадают добавляю в начало строки
                столько нулей чтобы компенсировать недостачу */
                mc.AdditionalCode = $"{mc.sign}:{additCode.PadLeft(reverse_value.Length, '0')}";
            }
        }


    }
}
