using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoubleLinkedList.models;

namespace DoubleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Elias", "Rist", new DateTime(2001, 8, 24));
            Person p2 = new Person("Thomas", "Mairer", new DateTime(2001, 3, 4));
            Person p3 = new Person("Tobias", "Flökinger", new DateTime(2000, 7, 4));
            Person p4 = new Person("Christian", "Hölbling", new DateTime(2000, 7, 4));

            DoubleLinkedList<Person> dll = new DoubleLinkedList<Person>();

            dll.Add(p);
            dll.Add(p2);
            dll.Add(p3);
            dll.Add(p4);

            Console.WriteLine(dll);


            Console.ReadKey();
        }
    }
}
