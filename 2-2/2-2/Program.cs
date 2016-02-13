using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your numbers");
            string a = Console.ReadLine();
            Write(a);
            Read();
            Console.WriteLine("Press any button");
            Console.ReadKey();
            Output();
            Console.ReadKey();
        }
        public static void Write(string inp)
        {
            FileStream fread = new FileStream("input.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            FileStream fwrite = new FileStream("output.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            StreamWriter input = new StreamWriter(fread);
            StreamWriter sw = new StreamWriter(fwrite);
            input.WriteLine(inp);
            StreamReader sr = new StreamReader(fread);
            input.Close()
            sw.Close();
            sr.Close();
            fwrite.Close();
            fread.Close();
        }
        static void Read()
        {
            FileStream fread = new FileStream("input.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            FileStream fwrite = new FileStream("output.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fwrite);
            StreamReader sr = new StreamReader(fread);
            int temp = 0;
            string[] token = sr.ReadLine().Split();
            try
            {
                int[] array = new int[token.Length];
                for (int i = 0; i < token.Length; i++)
                {
                    array[i] = int.Parse(token[i]);
                }
                for (int j=0;j<token.Length-1; j++)
                {
                    for (int i=0; i<token.Length-1; i++)
                    {
                        if (array[i]>array[i+1])
                        {
                            temp = array[i];
                            array[i] = array[i + 1];
                            array[i + 1] = temp;
                        }
                    }
                }
                int count = 0;
                for (int i=0;i<array.Length;i++)
                {
                    for(int k = 1; k < array.Length; k++)
                    {
                        if (array[i]%k==0)
                        {
                            count++;
                        }
                        if (count<=2)
                        {
                            sw.WriteLine("The minimum is {0};", array[i]);
                            break;
                        }
                        count = 0;
                    }
                }
                catch (Exception e)
            {
                Console.WriteLine(e);
            }
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
}
