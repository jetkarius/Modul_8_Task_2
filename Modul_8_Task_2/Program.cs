using System;
using System.IO;

namespace Modul_8_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите полный адрес для папки");
            string sourceDirectory = Console.ReadLine();
            if (Directory.Exists(sourceDirectory))
            {
                var di = new DirectoryInfo(sourceDirectory);
                DirSize(di);
                Console.WriteLine("Размер папки : {0}", DirSize(di));
            }
        }
        public static long DirSize(DirectoryInfo d)
        {
            long size = 0;
            FileInfo[] fis = d.GetFiles();
            foreach (FileInfo fi in fis)
            {
                size += fi.Length;
            }

            DirectoryInfo[] dis = d.GetDirectories();
            foreach (DirectoryInfo di in dis)
            {
                size += DirSize(di);
            }
            return size;
        }
    }
}

