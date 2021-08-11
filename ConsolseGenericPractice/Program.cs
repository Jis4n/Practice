using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolseGenericPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            //var list = new ArrayList();
            //list.Add(44);
            //int i1 = (int)list[0];
            //Console.WriteLine(i1);
            //foreach (int i2 in list)
            //{
            //    Console.WriteLine(i2);
            //}
            //Console.ReadKey();

            ///Generic Security练习示例
            //var list = new List<int>();
            //list.Add(44);
            //foreach (int i2 in list)
            //{
            //    Console.WriteLine(i2);
            //}
            //Console.ReadKey();

            ///Generic type safety
            //var list = new List<int>();
            //list.Add(44);
            //list.Add("mystring");
            //list.Add(new Program());
            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}

            ///Binary code reuse练习
            var list = new List<int>();
            list.Add(44);

            var stringList = new List<string>();
            stringList.Add("mystring");

            var programList = new List<Program>();
            programList.Add(new Program());
        }
    }
}
