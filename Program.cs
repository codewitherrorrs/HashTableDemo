using HashTableDemo;
using System.Collections;

namespace HastTableDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
            Hashtable h1 = new Hashtable();
            h1.Add(1, "sagar");
            h1.Add(2, "shahu");
            foreach(DictionaryEntry dictionaryEntry in h1) 
            {
                Console.WriteLine(dictionaryEntry.Key+ " : "+dictionaryEntry.Value);
            }
            */

            Findfrequency f1 = new Findfrequency();
            string str = "To be or not to be";
            // Console.WriteLine(str);
            string[] arr = str.Split(' ');
            foreach(var i in arr)
            {
                //Console.WriteLine(i);
                f1.addlist(i);
            }
           




        }  
    }
}