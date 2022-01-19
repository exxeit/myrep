using System;
using System.IO;
namespace Serialization
{
    class Files
    {
        static void Main()
        {
            Console.WriteLine("Введите строку для записи в файл:");
            string text = Console.ReadLine();
            // запись в файл
            using (FileStream fstream = new FileStream(@"D:\KPYP_LECTION\KPYP_LECTION\Serialization\Primer.txt", FileMode.Append, FileAccess.Write))
            {
                // преобразуем строку в байты
                byte[] array = System.Text.Encoding.Default.GetBytes(text);
                // запись массива байтов в файл
                fstream.Write(array, 0, array.Length);
                Console.WriteLine("Текст записан в файл");
            }
            // чтение из файла
            using (FileStream fstream = File.OpenRead(@"D:\KPYP_LECTION\KPYP_LECTION\Serialization\Primer.txt"))
            {
                // преобразуем строку в байты
                byte[] array = new byte[fstream.Length];
                // считываем данные
                fstream.Read(array, 0, array.Length);
                // декодируем байты в строку
                string textFromFile = System.Text.Encoding.Default.GetString(array);
                Console.WriteLine("Текст из файла: {0}", textFromFile);
            }
            Console.ReadLine();
        }
    }
}
