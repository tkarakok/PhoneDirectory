using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneDirectory
{

    // we create Methods class
    class Methods
    {

        // we created main menu method
        public void MainMenu()
        {
            Console.WriteLine("****** PHONE DİRECTORY WELCOME ******");
            Console.WriteLine(" Please select the action to be taken ");
            Console.WriteLine(" 1 - Add \n 2 - Delete \n 3 - Update \n 4- See All Directory \n 5- Searching in Directory ");

        }

        //  method showing all properties of a person
        void GetPersonInfo(Person person)
        {
            Console.WriteLine(" \n NAME      :{0}", person.Name);
            Console.WriteLine(" SURNAME      :{0}", person.SurName);
            Console.WriteLine(" PHONE NUMBER :{0}", person.PhoneNumber);
        }

        // if user select Add process we called this function and we adding person to directory
        public void Add(List<Person> persons)
        {
            Console.Write("Enter Name       :");
            string name = Console.ReadLine();       // we get person's name
            Console.Write("Enter Surname    :"); 
            string surName = Console.ReadLine();    // we get person's surname
            Console.Write("Enter Number     :"); 
            string phoneNumber = Console.ReadLine();    // we get person's phone number

            persons.Add(new Person { Name=name, SurName = surName, PhoneNumber = phoneNumber }); // we adding person and his/her fields 
            Console.Clear();
            Console.WriteLine(" Succesfully Added");

        }

        // if user select Delete process we called this function and we deleting person in directory
        public void Delete(List<Person> persons)
        {
            bool isRemove = false;
            WriteConsoleList(persons);
            Console.WriteLine(" ******************************** \n Please enter the name or surname of the person you want to remove ");
            string value = Console.ReadLine();  // we want to person's name or surname

            foreach (Person item in persons)
            {
                if (item.Name.Contains(value) || item.SurName.Contains(value) )  // we cheching input value in all person
                {
                    persons.Remove(item);  // if I have input value we deleting it in directory
                    isRemove = true;
                    break;
                }
            }
            if (isRemove)
            {
                Console.Clear();
                Console.WriteLine(" Succesfully Removed");
            }
            else
            {
                Console.WriteLine(" The data matching your search criteria could not be found in the directory. Please make a selection. ");
                Console.WriteLine(" 1- Back to Menu \n 2- Try Again");
                int action = Convert.ToInt32(Console.ReadLine());  

                switch (action)
                {
                    case 1:
                        Console.Clear();
                        MainMenu();  // we going to main menu
                        break;
                    case 2:
                        Console.Clear();
                        Methods methods = new();  // we call again delete metods 
                        methods.Delete(persons);
                        break;
                    default:
                        Console.WriteLine(" Please enter 1 or 2");
                        break;
                }
            }
            
        }

        // if user select Update process we called this function and we updating number value 
        public void Update(List<Person> persons)
        {
            bool isUpdated = false;
            WriteConsoleList(persons);
            Console.WriteLine(" ******************************** \n Please enter the name or surname of the person you want to update ");
            string value = Console.ReadLine();
            foreach (Person item in persons)
            {
                if (item.Name.Contains(value) || item.SurName.Contains(value))
                {
                    Console.WriteLine(" Please enter new number for " + item.Name); // we cheching input value and if I have value we chancing new value
                    string newNumber = Console.ReadLine();
                    item.PhoneNumber = newNumber;
                    isUpdated = true;
                    break;
                }
            }
            if (isUpdated)
            {
                Console.Clear();
                Console.WriteLine(" Succesfully Updated");

            }
            else
            {
                Console.WriteLine(" The data matching your search criteria could not be found in the directory. Please make a selection. ");
                Console.WriteLine(" 1- Back to Menu \n 2- Try Again");
                int action = Convert.ToInt32(Console.ReadLine());

                switch (action)
                {
                    case 1:
                        Console.Clear();
                        MainMenu();
                        break;
                    case 2:
                        Console.Clear();
                        Methods methods = new();
                        methods.Update(persons);  // we call again Update metods
                        break;
                    default:
                        Console.WriteLine(" Please enter 1 or 2");
                        break;
                }
            }
        }


        // if user select WriteConsoleList process we called this function and we writing all infos for one person 
        public void WriteConsoleList(List<Person> persons)  
        {
            foreach (Person item in persons)
            {
                Console.WriteLine(" ");
                Console.WriteLine(" ***************** ");
                GetPersonInfo(item);
                Console.WriteLine(" ");
            }
        }

        // if user select this process we searcing value in directory
        public void SearchingInDirectory(List<Person> persons)
        {
            Console.WriteLine(" Please choose the type of search");
            Console.WriteLine(" 1 - With name or surname : \n 2 - With phone number ");  // we choosing search type
            int action = Convert.ToInt32(Console.ReadLine()); 
            
            switch (action)
            {
                case 1:
                    Console.WriteLine(" Please enter name or surname"); // if user select 1 we searching with name or surname
                    string search = Console.ReadLine();
                    foreach (Person item in persons)
                    {
                        if (item.Name.Contains(search) || item.SurName.Contains(search)) // we checking input value
                        {
                            Console.Clear();
                            GetPersonInfo(item); // we getting info's this person
                            Console.WriteLine("\n");
                            MainMenu();
                            break;
                        }
                    }
                    
                    break;
                case 2:
                    Console.WriteLine(" Please enter phone number");
                    string number = Console.ReadLine(); //if user select 2 we searching with phone number
                    foreach (Person item in persons)
                    {
                        if (item.PhoneNumber.Contains(number)) // we chechking number if I have this value we writing console
                        {
                            Console.Clear();
                            GetPersonInfo(item);
                            Console.WriteLine("\n");
                            MainMenu();
                            break;
                        }
                    }
                    
                    break;
                default:
                    Console.WriteLine(" Please enter 1 or 2");
                    break;
            }
        }

        
    }
}
