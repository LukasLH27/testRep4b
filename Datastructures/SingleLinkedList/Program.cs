using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SingleLinkedList.models;

namespace SingleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klasse Person testen:
            
            Person p = new Person("Elias", "Rist", new DateTime(2001, 8, 24));
            // Console.WriteLine(p);

            Person p2 = new Person("Thomas", "Mairer", new DateTime(2001, 3, 4));
            Person p3 = new Person("Tobias", "Flökinger", new DateTime(2000, 7, 4));
            Person p4 = new Person("Christian", "Hölbling", new DateTime(2000, 7, 4));

            SingleLinkedList<Person> sll = new SingleLinkedList<Person>();
            
            sll.Add(p);
            sll.Add(p2);
            sll.Add(p3);
            sll.Add(p4);



            sll.ChangeItem(p2, p4);

            Console.WriteLine(sll);


            /*
            if (sll.Remove(null))
            {
                Console.WriteLine("Person wurde entfernt");
            }
            else
            {
                Console.WriteLine("Person wurde nicht entfernt - Parameter = null");
            }
            if (sll.Remove(p))
            {
                Console.WriteLine("Person wurde entfernt");
            }
            else
            {
                Console.WriteLine("Person wurde nicht entfernt - Parameter = null");
            }
            sll.Add(p);
            sll.Add(p2);
            sll.Add(p3);
            sll.Add(p4);
            //1.Fall
            if (sll.Remove(p3))
            {
                Console.WriteLine("Person wurde entfernt - Starteintrag wurde entfernt");
            }
            else
            {
                Console.WriteLine("Person wurde nicht entfernt - Starteintrag");
            }

            Console.WriteLine(sll);

            Console.WriteLine("-----");
            bool istStarteintrag;
            SingleLinkedListItem<Person> personBefore = new SingleLinkedListItem<Person>();

            personBefore = sll.FindItemBeforeItem(p2, out istStarteintrag);
            if (istStarteintrag)
            {
                Console.WriteLine("Es existiert kein Eintrag vor dem gesuchten Eintrag.");
                Console.WriteLine("Die gesuchte Person ist im Starteintrag enthalten!");
            }
            else if(personBefore != null)
            {
                Console.WriteLine("Item vor gesuchter Person existiert.");
                Console.WriteLine("Person vor der gesuchten Person lautet: ");
                Console.WriteLine(personBefore);
            }
            else
            {
                Console.WriteLine("gesuchte Person ist in dieser Liste nicht enthalten!");
            }

            */


            /*
            if(p == p2)
            {
                Console.WriteLine("p und p2 sing gleich: ==");
            }
            else
            {
                Console.WriteLine("p und p2 sind nicht gleich: ==");
            }

            if (p.Equals(p2))
            {
                Console.WriteLine("p und p2 sing gleich: Equals()");
            }
            else
            {
                Console.WriteLine("p und p2 sind nicht gleich: Equals()");
            }




            if (p == p3)
            {
                Console.WriteLine("p und p3 sing gleich: ==");
            }
            else
            {
                Console.WriteLine("p und p3 sind nicht gleich: ==");
            }

            if (p.Equals(p3))
            {
                Console.WriteLine("p und p3 sing gleich: Equals()");
            }
            else
            {
                Console.WriteLine("p und p3 sind nicht gleich: Equals()");
            }

            */
            Console.ReadKey();
            


            //SingleLinkedListItem testen:
            //generische Klasse verwenden:
            SingleLinkedListItem<Person> item = new SingleLinkedListItem<Person>(p, null);
            Console.WriteLine(item);

            //Klasse SSL testen
            //Methode Add() testen
            SingleLinkedList<Person> singleLL = new SingleLinkedList<Person>();
            if (singleLL.Add(p))
            {
                Console.WriteLine("Person wurde hinzugefügt!");
            }
            else
            {
                Console.WriteLine("Person konnte nicht hinzugefügt werden!");
            }
            if (singleLL.Add(new Person("Tobias", "Flöckinger", new DateTime(2000, 8, 13))))
            {
                Console.WriteLine("Person wurde hinzugefügt!");
            }
            else
            {
                Console.WriteLine("Person konnte nicht hinzugefügt werden!");
            }
            Console.WriteLine("Komplette SLL ausgeben:");
            Console.WriteLine(singleLL);
            


            Console.ReadKey();
        }
    }
}
