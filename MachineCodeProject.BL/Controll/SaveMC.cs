using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MachineCodeProject.BL.Controll
{
    /// <summary>
    /// Класс для сохранения машинного кода в файлы.
    /// </summary>
    public class SaveMC
    {

        public static async void SaveToTxt(string str)
        {

            using (FileStream f = new FileStream("node.txt", FileMode.OpenOrCreate))
            {
                byte[] bt = System.Text.Encoding.Default.GetBytes(str);
                await f.WriteAsync(bt, 0, bt.Length);
            }
        }
    }
}
