using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Read();
            Console.WriteLine("Press any key to see the result");
            Console.ReadKey();
            Output();
            Console.ReadKey();
        }
        static void Read()
        {
            FileStream fread = new FileStream("intpu.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            FileStream fwrite = new FileStream("output.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fread);
            StreamWriter sw = new StreamWriter(fwrite);

            string[] token = sr.ReadLine().Split();
            int temp= 0;
            int[] array = new int[token.Length]; 
            for (int j= 0; j<token.Length-1;j++)
            {
                for (int i=0; i<array.Length-1;i++)
                {
                    if(array[i]>array[i+1])
                    {
                        temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
            }
            sw.WriteLine("The maximum is {0} and the minimum is {1};",array[array.Length-1],array[0]);
            sw.Close();
            sr.Close();
            fwrite.Close();
            fread.Close();
        }
        static void Output()
        {
            FileStream fs = new FileStream("output.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            string a = sr.ReadLine();
            Console.WriteLine(a);
            fs.Close();
            sr.Close();
        }
    }
}
