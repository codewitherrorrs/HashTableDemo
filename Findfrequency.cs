using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HashTableDemo
{
    
    public class Findfrequency
    {

        public MyMapNode head;   
        public void addlist(string data)
        {
            MyMapNode newnode = new MyMapNode(data);
            
            if(this.head == null)
            {
               this.head = newnode;
            }
            else
            {
                MyMapNode temp = head;
                while(temp.key != null)
                {
                    temp = temp.key;
                }
                temp.key = newnode;
            }
            Console.WriteLine("{0}", newnode.value);
            
        }

   
        
    }
}
