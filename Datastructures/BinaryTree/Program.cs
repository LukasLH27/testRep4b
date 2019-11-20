using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BinaryTreeApp.models;

namespace BinaryTreeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree bt = new BinaryTree();

            int? bti1 = 20, bti2 = 5, bti3 = 30, bti4 = 2, bti5 = 5;

            bt.Add(bti1);
            bt.Add(bti2);
            bt.Add(bti3);
            bt.Add(bti4);
            bt.Add(bti5);

            bt.Minimum();




            //Add() Test
            /*
            Console.WriteLine("Bitte Zahl eingeben:");
            int inputZahl = Convert.ToInt32(Console.ReadLine());

            bt.Add(inputZahl);
            */

            //Count() Test
            /*
            Console.WriteLine("Anzahl der Elemente: {0}", bt.Count);
            */

            //Find() Test
            /*
            Console.WriteLine("Zahl suchen:");
            int zahlZumSuchen = Convert.ToInt32(Console.ReadLine());

            BinaryTreeItem gefundeneZahl = bt.Find(zahlZumSuchen);
            Console.WriteLine("Gefundene Zahl:");
            Console.WriteLine(gefundeneZahl);
            */



            Console.ReadKey();
        }
    }
}
