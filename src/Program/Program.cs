using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n1 = new Node("Marta",1);
            Node n2 = new Node("Francisco",2);
            Node n3 = new Node("Javier",3);
            Node n4 = new Node("Cesar",4);
            Node n5 = new Node("Angela",5);
            Node n6 = new Node("Santiago",6);
            Node n7 = new Node("Sandra",7);

            n1.AddChildren(n2);
            n1.AddChildren(n3);
            n2.AddChildren(n4);
            n2.AddChildren(n5);
            n3.AddChildren(n6);
            n3.AddChildren(n7);

            SumAgesContent SumAges = new SumAgesContent(n1);
            Console.WriteLine($"La suma de las edades de la familia es: {SumAges.GetAge()}");

            OldestChildContent OldestChild = new OldestChildContent(n1);
            Console.WriteLine($"El hijo/a mayor es: {OldestChild.GetPerson().Name}");

            LongestNameContent LongestName = new LongestNameContent(n1);
            Console.WriteLine($"Con el nombre mas largo es: {LongestName.GetPerson().Name}");
            // visitar el árbol aquí

            
        }
    }
}
