using System.IO;
namespace ConsoleApplication1
{
    class Files
    {
        static void Main()
        {
            var adress = File.Create(@"D:\KPYP_LECTION\KPYP_LECTION\FileIO\Primer.txt");//создание файла
            adress.Close();//закрытии файла и освобождение системных ресурсов
            File.Move(@"D:\KPYP_LECTION\KPYP_LECTION\FileIO\Primer.txt", "D:\\KPYP_LECTION\\KPYP_LECTION\\FileIO\\Primer\\Primer.txt");//переместить файл в указанную папку
            var adress2 = File.Create("Primer2.txt");//Помещается в директорию Debug
            adress2.Close();
            File.Delete("D:\\KPYP_LECTION\\KPYP_LECTION\\FileIO\\Primer\\Primer.txt");//удаление файла
            if (File.Exists("Primer2.txt"))//если файл2 существует
            { File.Copy("Primer2.txt", "D:\\KPYP_LECTION\\KPYP_LECTION\\FileIO\\new\\Primer2.txt", true); }//скопировать в указанную папку
        }
    }
}
