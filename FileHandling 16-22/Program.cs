using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\C#\SubiFile";
            FileStream fs = new FileStream(path, FileMode.Create,FileAccess.Write);
            Console.WriteLine("Data written Successfully");
            StreamWriter sw = new StreamWriter(fs,Encoding.UTF8);
            int[] arr = { 11, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, };
            foreach (var item in arr)
            {
                sw.WriteLine(item+ " "); 
            }
            //sw.WriteLine("This is Jiyaul");
            //sw.WriteLine("This is Game");
            //sw.WriteLine("This is Mouse");

            sw.Close();

            Console.ReadLine();




            //FileStream fs = new FileStream(path,FileMode.Append,FileAccess.Write);
            //string data = "I work for Impiger technologies";
            //byte[] buffer = Encoding.UTF8.GetBytes(data);
            //fs.Write(buffer, 0, buffer.Length);
            ////fs.WriteByte(65);//A
            ////fs.WriteByte(66);//B
            //Console.WriteLine("Data Written Successfully");
            //fs.Close();
            //Console.ReadKey();







            //string path= @"C:\C#\My Directory";
            //string path1 = @"C:\C#\My Directory1";
            //string path2 = @"C:\C#\Alice\Alice1";
            //DirectoryInfo dir=new DirectoryInfo(path2);
            //Console.WriteLine(dir.Name);
            //Console.WriteLine(dir.FullName); 
            //Console.WriteLine(dir.LastAccessTime);
            //Console.WriteLine(dir.LastWriteTime);
            //Console.WriteLine(dir.CreationTime);
            //Console.WriteLine(dir.Attributes);
            //Console.WriteLine(dir.Parent);
            //Console.WriteLine(dir.Root);


            //DirectoryInfo[] dirs= dir.GetDirectories();
            //foreach (var item in dirs)
            //{
            //    Console.WriteLine(item.GetFiles().Length);
            //}

            //dir.Delete(true);
            //dir.MoveTo(path1);
            //dir.Create();
            //dir.CreateSubdirectory("Panda Directory");
            //Console.WriteLine(item.FullName);
            //Console.ReadLine();


            //string path = @"C:\C#\data.txt";// verbatim literal
            //string path1 = @"C:\C#\Data\data1.txt";
            //File.Copy(path, path1); 

            //Console.ReadLine();
            //if (File.Exists(path))
            //{
            //    Console.WriteLine("File Founded!");
            //    string data=File.ReadAllText(path);
            //    Console.WriteLine(data);
            //}
            //else
            //{
            //    Console.WriteLine("File not Found");


        }
    }
}
