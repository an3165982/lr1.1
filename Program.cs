using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int i;
            i = 3;

            float x;
            x = 76.4F;

            double b;
            b = 3.4;

            char t;
            t = 'w';

            int a;            //явное приведение
            a = (int)b;

            char w;
            w = (char)i;

            byte z;
            z = (byte)i;

            int num = 21477;   //неявное приведение
            long bigNum = num;

            sbyte qw = 0;
            short u = qw;

            ushort ty = 1;
            int k = ty;

            long o = 423;
            float re = o;

            Object po = i;  // упаковка i, po ссылается на упакованный объект
            int m = (int)po;

            for (var j = 1; j < 10; j++)
            {
                var kl = 7;
                kl = j + 3;
            }
            Console.WriteLine("Сравнение Nullable переменных");
            int? x1 = null;
            int? x2 = 0;
            if (x1 == x2)
                Console.WriteLine("объекты равны");
            else
                Console.WriteLine("объекты не равны");

            string yt = "qwerty";
            string gh = "uytds";
            string iu = "ljbvfndv";
            string str1 = yt + " " + gh;
            string str2 = String.Copy(gh);
            string str3 = iu.Substring(4, 2);
            string value = "This is a short string.";
            char delimiter = 's';
            string[] substrings = value.Split(delimiter);
            string str5 = iu.Insert(4, " ");
            string str6 = str5.Replace("n", "000");
            string str = null;
            string str0 = "";
            if (String.IsNullOrEmpty(str))
                Console.WriteLine("Пустая или null");
            else
                Console.WriteLine("Не пустая и не null");
            StringBuilder MyStringBuilder = new StringBuilder("Hello World!");
            string str8 = "abc----def";
            str8 = str8.Remove(3, 4);
            str8 = str8.Insert(0, "ert");
            str8 = str8.Insert(str8.Length, "tre");
            int[,] myArr = new int[4, 5];
            Random ran = new Random();
            for (int v = 0; v < 4; v++)
            {
                for (int j = 0; j < 5; j++)
                {
                    myArr[v, j] = ran.Next(1, 15);
                    Console.Write("{0}\t", myArr[v, j]);
                }
                Console.WriteLine();
            }
            string[] arr1 = {"winter","spring", "summer", "automn"};
            int size = 0;
            for (int vv = 0; vv < arr1.Length; vv++)
            {
                Console.Write("{0}\t", arr1[vv]);
                size++;
            }
            Console.WriteLine();
            Console.Write("Size of arr1: {0}\t", size);
            Console.WriteLine("Какой элемент надо заменить?");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("На что заменить данный элемент?");
            string mn=Console.ReadLine();
            arr1.SetValue(mn, num-1);
            for (int vv = 0; vv < arr1.Length; vv++)
            {
                Console.Write("{0}\t", arr1[vv]);
            }
            // Объявляем ступенчаты массив
            int[][] arr2 = new int[3][];
            arr2[0] = new int[2];
            arr2[1] = new int[3];
            arr2[2] = new int[4];
            Console.WriteLine();
            // Инициализируем ступенчатый массив
            for (int p=0; p < 3; p++)
            {
                for (int p1 = 0; p1 < arr2[p].Length; p1++)
                {
                    Console.WriteLine("Введите "+(p1+1)+" элемент "+(p+1)+" строки ступенчатого массива");
                    arr2[p][p1] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Ступенчатый массив: ");
            for (int p2 = 0; p2 < 3; p2++)
            {
                for (int p3 = 0; p3 < arr2[p2].Length; p3++)
                {
                    Console.Write(arr2[p2][p3]);
                }
                Console.WriteLine(); 
            }

            Console.ReadLine();
            var myTuple = Tuple.Create<int, string, char, string, ulong>(12, "qwerty", '@', "trewq", 345);
            Console.WriteLine(myTuple);
            Console.WriteLine(myTuple.Item1);
            Console.WriteLine(myTuple.Item3);
            Console.WriteLine(myTuple.Item4);
            var myTuple2 = Tuple.Create<int, string, char, string, ulong>(11, "werty", '$', "trew", 35);
            if (myTuple.Item1 == myTuple2.Item1)
                Console.WriteLine("Первые элементы кортежей myTuple и myTuple2 равны");
            else
                Console.WriteLine("Первые элементы кортежей myTuple и myTuple2 разные");
            void Function(int[] a3, string a1)
            {
                int mx = 0;
                int min=a3[0];
                int sum = 0;
                for(var i1=0;i1<a3.Length;i1++)
                {
                    if (a3[i1] > mx)
                        mx = a3[i1];
                }
                for (var i1 = 0; i1 < a3.Length; i1++)
                {
                    if (a3[i1] < min)
                        min = a3[i1];
                }
                for (var i1 = 0; i1 < a3.Length; i1++)
                {
                    sum = sum + a3[i1];
                }
                string t1 =a1.Substring(0, 1);
                var myTuple1 = Tuple.Create<int, int, int, string>(mx,min,sum,t1);
                Console.WriteLine(myTuple1);
            }
            int[] b1 = {1,2,3,4,5,6,7};
            Function(b1, yt);
        }
    }
}