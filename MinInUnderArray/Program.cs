using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace MinInUnderArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //путь
            string inputpath = "D:\\SolutionsForSpaceApp\\2028\\input.txt";
            string outputpath = "D:\\SolutionsForSpaceApp\\2028\\output.txt";

            //создание файлов
            FileStream fs = new FileStream(inputpath, FileMode.OpenOrCreate);
            fs.Close();
            FileStream fsout = new FileStream(outputpath, FileMode.OpenOrCreate);
            fsout.Close();

            //переменная для обьвления размера массива#1
            double a;
            using (var readera = new StreamReader(inputpath))
            {
                a = Convert.ToInt32(readera.ReadLine());  // записываем в переменную
            };
            //запись в строку содержимого 2 строки файла
            string secondLine;
            using (var readersecond = new StreamReader(inputpath))
            {
                readersecond.ReadLine(); //пропуск 1 строки
                secondLine = readersecond.ReadLine();  // записываем в переменную
            }

            //запись из строки в массив строк с разделением
            string[] secondlineforint = secondLine.Split(' ');

            int[] A;
            A = new int[Convert.ToInt32(a)];

            int count = 0;
            foreach (var s in secondlineforint)
            {
                if (count <= a)
                {
                    A[count] = Convert.ToInt32(s);

                    count++;
                }
            }

            int[] sravnarr = new int[5] { 0,1,2,3,4};

            int[] counter = new int[5] {0,0,0,0,0 };

            for (int i = 0; i < a; i++)
            {
                if (A[i] == sravnarr[0])
                {
                    counter[0]++;
                }
                else if (A[i] == sravnarr[1])
                {
                    counter[1]++;
                }
                else if (A[i] == sravnarr[2])
                {
                    counter[2]++;
                }
                else if (A[i] == sravnarr[3])
                {
                    counter[3]++;
                }
                else if (A[i] == sravnarr[4])
                {
                    counter[4]++;
                }
            }

            string SEmpty = " ";
            string outputstring = "";
            //если совпадений нет и строка пустая, выводим 0
            if (outputstring == SEmpty)
            {
            }
            else
            {
                //через writer записываю в нужном виде
                using (var outputwriter = new StreamWriter(outputpath))
                {   if (counter[0] != 0)
                    {
                        outputwriter.Write(A[0]);
                        outputwriter.Write(' ');
                        outputwriter.WriteLine(counter[0]);
                    }
                    if (counter[1] != 0)
                    {
                        outputwriter.Write(A[1]);
                        outputwriter.Write(' ');
                        outputwriter.WriteLine(counter[1]);
                    }
                    if (counter[2] != 0)
                    {
                        outputwriter.Write(A[2]);
                        outputwriter.Write(' ');
                        outputwriter.WriteLine(counter[2]);
                    }
                    if (counter[3] != 0)
                    {
                        outputwriter.Write(A[3]);
                        outputwriter.Write(' ');
                        outputwriter.WriteLine(counter[3]);
                    }
                    if (counter[4] != 0)
                    {
                        outputwriter.Write(A[4]);
                        outputwriter.Write(' ');
                        outputwriter.WriteLine(counter[4]);
                    }
                }
            }




        }
    }
}
