using System.IO;
using System;
namespace File_write
{
    class Files
    {
        static void Main(string[] args)
        {
            string str = "192.168.20.1";
            File.WriteAllText("D:\\KPYP_LECTION\\KPYP_LECTION\\File_write\\Primer.txt", str);
            Console.WriteLine();
            File.AppendAllText("D:\\KPYP_LECTION\\KPYP_LECTION\\File_write\\Primer.txt", " текст метода AppendAllText ()");
        }
    }
}
