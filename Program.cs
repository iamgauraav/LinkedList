using System;
using System.Collections.Generic;


namespace Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            //what type it is it is interger typeso we use int
            LinkedList<int> myList = new LinkedList<int>();
            myList.Add(20);
            myList.Add(30);
            myList.Add(40);
            myList.Add(50);
            myList.Add(60);
            myList.Add(70);
            Console.WriteLine("Before position adding");
            //calling display method
            myList.Display(); 
            myList.Add(100, 3);
            myList.Add(100, 4);
            myList.Add(100, 5);
            Console.WriteLine("After position adding");
            //calling display method
            myList.Display();
            //removing position 
            myList.Remove(4);
            Console.WriteLine("After position adding");
            //calling display method
            myList.Display();
            Console.WriteLine("****************************************");
            //what type it is it is string typeso we use string
            LinkedList<string> myListStr = new LinkedList<string>();
            myListStr.Add("Raj");
            myListStr.Add("Raju");
            myListStr.Add("Ravi");
            myListStr.Add("Ritu");
            myListStr.Add("Rupal");
            myListStr.Add("Ria");
            //calling display method
            myListStr.Display();

            Console.WriteLine("******************************************");
        }
    }
}
