using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_side
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<int, string> isimler = new Dictionary<int, string>();
            //isimler.Add(1, "Orhun");
            //isimler.Add(2, "Ayşe");
            //isimler.Add(3, "Ahmet");
            //isimler.Add(4, "Engin");

            //Console.WriteLine(isimler[2].ToString());

            //isimler[3] = "Anıl";

            //foreach (var item in isimler)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            MyDictionary<int,string> myDictionary = new MyDictionary<int,string>();
            myDictionary.Add(1, "Kitap");
            myDictionary.Add(2, "Müzik");
            myDictionary.Add(3, "Oyuncak");

            Console.WriteLine(myDictionary.Count());

            Console.WriteLine("------------------------------------");

            myDictionary.printDictionary();
        }
    }

    class MyDictionary<TKey, TValue>
    {
        TKey[] keyArray;
        TValue[] valueArray;
        public MyDictionary()
        {
            keyArray = new TKey[0];
            valueArray = new TValue[0];
        }
        public void Add(TKey key, TValue value)
        {
            TKey[] tempKeyArray = keyArray;
            TValue[] tempValueArray = valueArray;
            
            keyArray = new TKey[keyArray.Length + 1];
            valueArray = new TValue[valueArray.Length + 1];

            for (int i = 0; i < tempKeyArray.Length; i++)
            {
                keyArray[i] = tempKeyArray[i];
                valueArray[i] = tempValueArray[i];
            }
            keyArray[keyArray.Length - 1] = key;
            valueArray[valueArray.Length - 1] = value;
        }

        public int Count()
        {
            return keyArray.Length;
        }

        public void printDictionary()
        {
            for (int i = 0; i < keyArray.Length; i++)
            {
                Console.WriteLine("Key->" + keyArray[i].ToString() + ", Value->" + valueArray[i].ToString() );
            }
        }

    }


}
