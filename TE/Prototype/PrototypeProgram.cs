using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TE.Prototype
{
    class PrototypeProgram
    {
        public static void PrototypeMain() // idk how you would demo this
        {
            Console.WriteLine("==========");
            Console.WriteLine("Prototype");
            Console.WriteLine("==========");

            Person p1 = new Person();
            p1.Age = 42;
            p1.BirthDate = Convert.ToDateTime("1977-01-01");
            p1.Name = "Jack Daniels";
            p1.IdInfo = new IdInfo(666);

            // Perform a shallow copy of p1 and assign it to p2.
            Person p2 = (Person)p1.shallowClone();
            // Make a deep copy of p1 and assign it to p3.
            Person p3 = (Person)p1.deepClone();

            // Display values of p1, p2 and p3.
            #region pradiniai duomenys
            Console.WriteLine("Original values of p1, p2, p3:");
            Console.WriteLine("   p1 instance values: ");
            DisplayValues(p1);
            Console.WriteLine("   p2 instance values:");
            DisplayValues(p2);
            Console.WriteLine("   p3 instance values:");
            DisplayValues(p3);
            #endregion

            #region pakeitimai
            // Change the value of p1 properties and display the values of p1,
            // p2 and p3.
            p1.Age = 32;
            p1.BirthDate = Convert.ToDateTime("1900-01-01");
            p1.Name = "Frank";
            p1.IdInfo.IdNumber = 7878;
            Console.WriteLine("\nValues of p1, p2 and p3 after changes to p1:");
            Console.WriteLine("   p1 instance values: ");
            DisplayValues(p1);
            Console.WriteLine("   SHALLOW== p2 instance values (reference values have changed):");
            DisplayValues(p2);
            Console.WriteLine("   DEEP== p3 instance values (everything was kept the same):");
            DisplayValues(p3);
            #endregion
        }

        public static void DisplayValues(Person p)
        {
            Console.WriteLine("      Name: {0:s}, Age: {1:d}, BirthDate: {2:MM/dd/yy}",
                p.Name, p.Age, p.BirthDate);
            Console.WriteLine("      ID#: {0:d}", p.IdInfo.IdNumber);
        }

    }
}
