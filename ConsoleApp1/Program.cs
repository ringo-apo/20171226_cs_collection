using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList
            ArrayList arrayList = new ArrayList();
            arrayList.Add("One");
            arrayList.Add("Two");
            arrayList.Add("Three");

            for (int i=0; i<arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }

            Console.WriteLine("");
            foreach (Object _ in arrayList)
            {
                Console.WriteLine(_);
            }

            //List
            List<string> list = new List<string>();
            list.Add("One");
            list.Add("Two");
            list.Add("Three");

            Console.WriteLine("");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);

            }

            Console.WriteLine("");
            foreach (string _ in list)
            {
                Console.WriteLine(_);
            }

            List<Class1> class1s = new List<Class1>();

            class1s.Add(new Class1 { id = 1, name = "ぱんだ", price = 100 });
            class1s.Add(new Class1 { id = 2, name = "にんじん", price = 10 });
            class1s.Add(new Class1 { id = 3, name = "パソコン", price = 50 });

            //全リスト表示(for)
            Console.WriteLine("");
            for (int i = 0; i < class1s.Count; i++)
            {
                Console.WriteLine("id={0},name={1},price={2}", class1s[i].id, class1s[i].name, class1s[i].price);
            }

            //全リスト表示(foreach)
            Console.WriteLine("");
            foreach (Class1 _ in class1s)
            {
                Console.WriteLine("id={0},name={1},price={2}", _.id, _.name, _.price);
            }

            //全リスト表示(name列だけを表示)
            Console.WriteLine("");
            foreach (Class1 _ in class1s)
            {
                Console.WriteLine("name={0}", _.name);
            }

            //name列だけを取りだし別リストに代入
            List<string> class1Name = new List<string>();
            class1Name.AddRange(from _ in class1s select _.name);

            Console.WriteLine("");
            foreach (string _ in class1Name)
            {
                Console.WriteLine("name={0}", _);
            }
        }
    }
}
