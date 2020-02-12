using System;
using System.Collections.Generic;
using System.Text;

namespace oblig_1
{
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public Person Mother { get; set; }
        public Person Father { get; set; }

        public Person Child { get; set; }
        public Person Child2 { get; set; }

        public Person Child3 { get; set; }

        public void Show()
        {
            Console.WriteLine();
            if (FirstName != null)
            {
                Console.WriteLine("Fornavn: " + FirstName);
            }

            if (LastName != null)
            {
                Console.WriteLine("Etternavn: " + LastName);
            }

            if (BirthYear != 0)
            {
                Console.WriteLine("Fødselsår: " + BirthYear);
            }
            if (Mother != null)
            {
                Console.WriteLine("Mor: " + Mother.FirstName);
            }

            if (Father != null)
            {
                Console.WriteLine("Far: " + Father.FirstName);
            }

            if (Child != null)
            {
                Console.WriteLine("Sønn: " + Child.FirstName);
            }

            if (Child3 != null)
            {
                Console.WriteLine("Sønn: " + Child3.FirstName);
            }

            if (Child2 != null)
            {
                Console.WriteLine("Datter: " + Child2.FirstName);
            }

            if (Id != 0)
            {
                Console.WriteLine("Id: " + Id);
            }

            Console.WriteLine();

        }
    }
}