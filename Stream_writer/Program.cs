using System;
using System.IO;
//Hello world
namespace Stream_writer
{
    class Files
    {
        static void Main()
        {
            string readPath = @"D:\KPYP_LECTION\KPYP_LECTION\Stream_writer\Primer.txt";
            string writePath = @"D:\KPYP_LECTION\KPYP_LECTION\Stream_writer\Primer2.txt";
            string text = "";
            try
            {
                using (StreamReader sr = new StreamReader(readPath, System.Text.Encoding.UTF8))
                {
                    text = sr.ReadToEnd();
                }
                using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.UTF8))
                {
                    sw.WriteLine(text);
                }
                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.UTF8))
                {
                    sw.WriteLine("Дозапись");
                    sw.Write(4.5);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Файл успешно создан");
            Console.ReadKey();
        }
    }
}
