using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace IEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arrayList = new List<int>();
            arrayList.Add(90);
            arrayList.Add(100);
            arrayList.Add(110);
            arrayList.Add(120);
            arrayList.Add(130);
            Console.WriteLine("Enumerable Output:");
            IEnumerable<int> iEnumerableObj = (IEnumerable<int>)arrayList;
            foreach(int i in iEnumerableObj)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Enumerator Output:");
            IEnumerator<int> ienumeratorObj = arrayList.GetEnumerator();
            while (ienumeratorObj.MoveNext())
            {
                Console.WriteLine(ienumeratorObj.Current.ToString());
            }
            ienumeratorObj.Reset();
            Console.WriteLine("Starts Here");
            iEnumeratorMethodOne(ienumeratorObj);
            
            Console.ReadLine();
        }
        static void iEnumeratorMethodOne(IEnumerator<int> i)
        {
            while (i.MoveNext())
            {
                Console.WriteLine(i.Current);

                if (i.Current > 100)
                {
                    //Console.WriteLine("Method1");
                    iEnumeratorMethodTwo(i);
                }
            }
        }

        static void iEnumeratorMethodTwo(IEnumerator<int> i)
        {
            while (i.MoveNext())
            {
                if (i.Current < 100)
                {
                    //Console.WriteLine("Method2");
                    iEnumeratorMethodOne(i);
                }
                //Console.WriteLine("Method2");
                Console.WriteLine(i.Current);
            }
        }
        //create IEnumerable  


    }
}
