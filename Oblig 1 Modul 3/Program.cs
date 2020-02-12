using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace oblig_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Velkommen til slektstre!");
            var listOfPeopleVar = PersonList();

            while (true)
            {
                Console.WriteLine("Skriv hjelp for mer informasjon");

                var input = Console.ReadLine();
           
                if (input == "hjelp")
                {
                    ShowHelpText();
                  
                }

                if (input == "liste")
                {
                    ShowAllPeople(listOfPeopleVar);
                 
                }


                if (input.StartsWith("vis"))
                {
                    int id = Convert.ToInt32(input.Substring(4, 1));
                    listOfPeopleVar[id - 1].Show();
                }
            }
        }

        private static void ShowAllPeople(List<Person> listOfPeopleVar)
        {
            for (var i = 0; i < listOfPeopleVar.Count; i++)
            {
                listOfPeopleVar[i].Show();
               
            }
        }

        private static void ShowHelpText()
        {
            Console.WriteLine("hjelp => viser en hjelpetekst som forklarer alle kommandoene") ;


            Console.WriteLine("liste => lister alle personer med id, fornavn, fødselsår, dødsår " +
                              "og navn og id på mor og far om det finnes registrert");
     
            Console.WriteLine("vis <id> => viser en bestemt person med mor, far og barn " +
                              "(og id for disse, slik at man lett kan vise en av dem)");
        }


        public static List<Person> PersonList()
        {
            var sverreMagnus = new Person { Id = 1, FirstName = "Sverre Magnus", BirthYear = 2005 };
            var ingridAlexandra = new Person { Id = 2, FirstName = "Ingrid Alexandra", BirthYear = 2004 };
            var marius = new Person { Id = 5, FirstName = "Marius", LastName = "Borg Høiby", BirthYear = 1997 };
            var haakon = new Person { Id = 3, FirstName = "Haakon Magnus", BirthYear = 1973,};
            var metteMarit = new Person { Id = 4, FirstName = "Mette-Marit", BirthYear = 1973,};
            var harald = new Person { Id = 6, FirstName = "Harald", BirthYear = 1937};
            var sonja = new Person { Id = 7, FirstName = "Sonja", BirthYear = 1937};
            var olav = new Person { Id = 8, FirstName = "Olav", BirthYear = 1903};


            sverreMagnus.Father = haakon;
            sverreMagnus.Mother = metteMarit;
            ingridAlexandra.Father = haakon;
            ingridAlexandra.Mother = metteMarit;
            marius.Mother = metteMarit;
            haakon.Father = harald;
            haakon.Mother = sonja;
            harald.Father = olav;
            metteMarit.Child = sverreMagnus;
            metteMarit.Child2 = ingridAlexandra;
            metteMarit.Child3 = marius;
            haakon.Child = sverreMagnus;
            haakon.Child2 = ingridAlexandra;
            sonja.Child = haakon;
            harald.Child = haakon;
            olav.Child = harald;
            

            var list = new List<Person>
                {
                    sverreMagnus,
                    ingridAlexandra,
                    haakon,
                    metteMarit,
                    marius,
                    harald,
                    sonja,
                    olav
                };

            return list;
        }

    }
}