using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleLinkedList list = new SimpleLinkedList();
            list.Addnote(56);
             list.Addnote(30);
             list.Addnote(70);
            //list.FirstDelete();
            list.LastDelete();
            //list.Insert(2, 30);
            list.Display();


        }
    }
}