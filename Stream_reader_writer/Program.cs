using System;
using System.IO;

namespace Stream_reader_writer
{
    class Files
    {
        static void Main()
        {
            string path = @"D:\KPYP_LECTION\KPYP_LECTION\Stream_reader_writer\Primer.txt";
            try
            {
                Console.WriteLine("******считываем весь файл********");
                using (StreamReader sr = new StreamReader(path))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }
                Console.WriteLine();
                Console.WriteLine("******считываем построчно********");
                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.UTF8))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
                Console.WriteLine();
                Console.WriteLine("******считываем блоками********");
                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.UTF8))
                {
                    char[] array = new char[4];
                    // считываем 4 символа
                    sr.Read(array, 0, 4);
                    Console.WriteLine(array);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
