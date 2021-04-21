using MachineCodeProject.BL.Controll;
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
        /// Число, в десятеричной СС, для перевода.
        /// </summary>
        int numeric;

        /// <summary>
        /// Число, в десятеричной СС, для перевода.
        /// </summary>
        public int Numeric { get { return numeric; }
            set { numeric = value; sign = (value < 0) ? 1 : 0; } }

        /// <summary>
        /// Знак числа.
        /// </summary>
        public int sign;

        /// <summary>
        /// Прямой код.
        /// </summary>
        public string StraightCode { get; set; }

        /// <summary>
        /// Обратный код
        /// </summary>
        public string ReversCode { get; set; }

        /// <summary>
        /// Дополнительный код.
        /// </summary>
        public string AdditionalCode { get; set; }

        /// <summary>
        /// Создание нового экземпляра класса.
        /// </summary>
        /// <param name="num">Число, в десятеричной СС, для перевода.</param>
        public MachineCodeClass(int num)
        {
            Numeric = num;
        }

        // TODO: Добавить еще один конструктор с массивом string
        /// <summary>
        /// Создать новое число и прямой, обратный, дополнительный код.
        /// </summary>
        /// <param name="num">Число, в десятеричной СС, для перевода.</param>
        /// <param name="straigh">Прямой код.</param>
        /// <param name="revers">Обратный код.</param>
        /// <param name="additional">Дополнительный код.</param>
        public MachineCodeClass(int num,
                                string straigh,
                                string revers,
                                string additional)
        {
            #region Проверка ошибок
            if (string.IsNullOrWhiteSpace(straigh))
                throw new ArgumentException("Прямой код не может быть равен null или быть пустым.", nameof(straigh));

            if (string.IsNullOrWhiteSpace(revers))
                throw new ArgumentException("Обратный код не может быть равен null или быть пустым.", nameof(revers));

            if (string.IsNullOrWhiteSpace(additional))
                throw new ArgumentException("Дополнительный код не может быть равен null или быть пустым.", nameof(additional));
            #endregion

            Numeric = num;
            StraightCode = straigh;
            ReversCode = revers;
            AdditionalCode = additional;
        }

        /// <summary>
        /// Оператор сложения машинных кодов.
        /// </summary>
        /// <param name="mc1">Класс с первым слогаемым.</param>
        /// <param name="mc2">Класс с вторым слогаемым.</param>
        /// <returns>Результат сложения.</returns>
        public static MachineCodeClass operator +(MachineCodeClass mc1, MachineCodeClass mc2)
        {
            #region Проверка объектов
            if (mc1 == null)
                throw new ArgumentNullException("Класс не может быть равен null.", nameof(mc1));

            if (mc2 == null)
                throw new ArgumentNullException("Класс не может быть равен null.", nameof(mc2));
            #endregion

            return TranslateInCode.TranslateNumericInMachineCode(mc1.Numeric + mc2.Numeric);
        }

        /// <summary>
        /// Оператор для вычетания машинных кодов.
        /// </summary>
        /// <param name="mc1">Класс с вычитаемм.</param>
        /// <param name="mc2">Класс вычетателя.</param>
        /// <returns>Результат вычитания.</returns>
        public static MachineCodeClass operator -(MachineCodeClass mc1, MachineCodeClass mc2)
        {
            #region Проверка объектов
            if (mc1 == null)
                throw new ArgumentNullException("Класс не может быть равен null.", nameof(mc1));

            if (mc2 == null)
                throw new ArgumentNullException("Класс не может быть равен null.", nameof(mc2));
            #endregion

            return TranslateInCode.TranslateNumericInMachineCode(mc1.Numeric - mc2.Numeric);
        }

        /// <summary>
        /// Оператор умножения машинного кода.
        /// </summary>
        /// <param name="mc1">Класс с множимым.</param>
        /// <param name="mc2">Класс с множителем.</param>
        /// <returns>Результат Умножения.</returns>
        public static MachineCodeClass operator *(MachineCodeClass mc1, MachineCodeClass mc2)
        {
            #region Проверка объектов
            if (mc1 == null)
                throw new ArgumentNullException("Класс не может быть равен null.", nameof(mc1));

            if (mc2 == null)
                throw new ArgumentNullException("Класс не может быть равен null.", nameof(mc2));
            #endregion

            return TranslateInCode.TranslateNumericInMachineCode(mc1.Numeric * mc2.Numeric);
        }

        /// <summary>
        /// Оператор для деления машинного кода.
        /// </summary>
        /// <param name="mc1">Класс с делимым.</param>
        /// <param name="mc2">Класс с делителем.</param>
        /// <returns>Результат деления.</returns>
        public static MachineCodeClass operator /(MachineCodeClass mc1, MachineCodeClass mc2)
        {
            #region Проверка объектов
            if (mc1 == null)
                throw new ArgumentNullException("Класс не может быть равен null.", nameof(mc1));

            if (mc2 == null)
                throw new ArgumentNullException("Класс не может быть равен null.", nameof(mc2));
            #endregion

            return TranslateInCode.TranslateNumericInMachineCode(mc1.Numeric / mc2.Numeric);
        }

        /// <summary>
        /// Метод преобразования класса в тип string.
        /// </summary>
        /// <returns>результат преобразования.</returns>
        public override string ToString()
        {
            return $"Число: {numeric}\n Прямой код: {StraightCode}\n Обратный код: {ReversCode}\n Дополнительный код: {AdditionalCode}";
        }

    }
}
