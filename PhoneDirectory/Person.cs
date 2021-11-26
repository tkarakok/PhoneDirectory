using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneDirectory
{
    class Person
    {
        // we writing one Person has all fields
        private string _Name;
        private string _SurName;
        private string _PhoneNumber;
       
        // we encapsulation Person class fields
        public string Name
        {
            get => _Name;
            set
            {
                // we check our surname has characters  
                // if we have just true input so we set value
                if (!value.IsCharacter())
                {
                    _Name = value;
                }
                else
                {
                    Console.WriteLine("Please don't use chracter");
                }
            }
        }
        public string SurName
        {
            get => _SurName;
            set
            {
                // we check our surname has characters  
                // if we have just true input so we set value
                if (!value.IsCharacter())
                {
                    _SurName = value;
                }
                else
                {
                    Console.WriteLine("Please don't use chracter");
                }
            }
        }
        public string PhoneNumber 
        { 
            get => _PhoneNumber;
            set 
            {
                // we check our phone number has characters or letters 
                // if we have just number so we set value
                if (value.IsNumber())
                {
                    _PhoneNumber = value;
                }
                else
                {
                    Console.WriteLine(" Please enter number without special chracters and letters");
                }
            } 
        }
       
    }

    // we write extensions methods
    public static class CheckInputs
    {
        public static bool IsCharacter(this string param)
        {
            string[] permis = { "/", "*", "-", "+", "&", "!", "'", "#", "%", "(", ")", "{", "}" };
            bool has = false;
            foreach (string item in permis)
            {
                if (param.Contains(item))
                {
                    has = true;
                    break;
                }
            }
            return has;
        }

        public static bool IsNumber(this string param)
        {
            foreach (char chr in param)
            {
                if (!Char.IsNumber(chr)) 
                    return false;
            }
            return true;
        }
    }
}
