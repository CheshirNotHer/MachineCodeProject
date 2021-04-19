using System;
using System.Collections.Generic;
using System.Text;

namespace MachineCodeProject.BL.Model
{
    /// <summary>
    /// Класс для хранения числа и его прямого, обратного, и дополнительного кода.
    /// </summary>
    public class MachineCodeClass
    {
        /// <summary>
        /// Число
        /// </summary>
        double numeric;

        /// <summary>
        /// Прямой код.
        /// </summary>
        string StraightCode;

        /// <summary>
        /// Обратный код
        /// </summary>
        string ReversCode;

        /// <summary>
        /// Дополнительный код.
        /// </summary>
        string AdditionalCode;

        // TODO: Добавить еще один конструктор с массивом string
        /// <summary>
        /// Создать новое число и прямой, обратный, дополнительный код.
        /// </summary>
        /// <param name="num">Число.</param>
        /// <param name="straigh">Прямой код.</param>
        /// <param name="revers">Обратный код.</param>
        /// <param name="additional">Дополнительный код.</param>
        public MachineCodeClass(double num, 
                                string straigh, 
                                string revers, 
                                string additional)
        {
            numeric = num;
            if(string.IsNullOrWhiteSpace(straigh))
                throw new ArgumentException("Прямой код не может быть равен null или быть пустым.",nameof(straigh));
            StraightCode = straigh;

            if (string.IsNullOrWhiteSpace(revers))
                throw new ArgumentException("Обратный код не может быть равен null или быть пустым.", nameof(revers));
            ReversCode = revers;

            if (string.IsNullOrWhiteSpace(additional))
                throw new ArgumentException("Дополнительный код не может быть равен null или быть пустым.", nameof(additional));
            AdditionalCode = additional;
        }

        public override string ToString()
        {
            return $"{numeric}";
        }

    }
}
