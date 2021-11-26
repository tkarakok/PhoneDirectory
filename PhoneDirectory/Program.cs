using System;
using System.Collections.Generic;

namespace PhoneDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            // we defining default person object
            List<Person> persons = new List<Person>();
            persons.Add(new Person { Name = "Tunahan" , SurName = "KARAKOK", PhoneNumber= "1"});
            persons.Add(new Person { Name = "Arzu" , SurName = "KARAKOK", PhoneNumber= "2"});
            persons.Add(new Person { Name = "Timucin" , SurName = "KARAKOK", PhoneNumber= "3"});
            persons.Add(new Person { Name = "Cengiz" , SurName = "KARAKOK", PhoneNumber= "4"});
            persons.Add(new Person { Name = "Emin" , SurName = "Tura", PhoneNumber= "5"});
            Methods methods = new();

        main:
            methods.MainMenu();

            int action = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (action)
            {
                case 1:
                    methods.Add(persons);
                    goto main;
                case 2:
                    methods.Delete(persons);
                    goto main;
                case 3:
                    methods.Update(persons);
                    goto main; 
                case 4:
                    methods.WriteConsoleList(persons);
                    goto main;
                case 5:
                    methods.SearchingInDirectory(persons);
                    break;
                default:
                    Console.WriteLine(" Please enter just number (1-5)");
                    goto main; 
            }




        }


        
    }
}
