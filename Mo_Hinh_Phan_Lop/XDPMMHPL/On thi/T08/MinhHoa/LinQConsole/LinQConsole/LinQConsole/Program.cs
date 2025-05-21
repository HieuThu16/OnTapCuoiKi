using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinQConsole
{
    class Program
    {
        static public void Linq5()
        {
            string[] digits = { "zero", "one", "a", "three", "four", "five", "six", "seven", "eight", "nine" };

            var shortDigits = digits.Where((digit, index) => digit.Length < index);

            Console.WriteLine("Short digits:");
            foreach (var d in shortDigits)
            {
                Console.WriteLine("The word {0} is shorter than its value.", d);
            }
        }

        static void Main(string[] args)
        {
            //Linq5();

            
            string[] names = { "Phạm Thị Quỳnh",
                                "Lưu Khả", 
                                "Nguyễn Duy Hoài", 
                                "Trần Hoàng", 
                                "Huỳnh Thị Mỹ"};
            var result1 = from name in names // foreach(string name in names)
                         where name.Contains("H")
                         orderby name
                         select name;

            foreach (var name in result1)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("------");

            List<Person> people = Person.GetListOfPerson();
            var result2 = from p in people
                          where (DateTime.Today.Year - p.iBirthYear) > 22
                          select new
                          {
                              Name = p.sName,
                              Age = DateTime.Today.Year - p.iBirthYear,
                              NickName = p.sName + "_ cu tủn"
                          };
            foreach (var p in result2)
            {
                Console.WriteLine(p.NickName + " - " + p.Age + " years old.");
            }
            
        }
    }

    

    class Person
    {
        public string sName;
        public int iBirthYear;

        public Person(string _name, int _birthYear)
        {
            sName = _name;
            iBirthYear = _birthYear;
        }

        public static List<Person> GetListOfPerson()
        {
            List<Person> result = new List<Person>();
            result.Add(new Person("Phạm Thị Quỳnh", 1988));
            result.Add(new Person("Lưu Khả", 1990));
            result.Add(new Person("Nguyễn Duy Hoài", 1987));
            result.Add(new Person("Trần Hoàng", 1990));
            result.Add(new Person("Huỳnh Thị Mỹ", 1990));

            return result;
        }
    }
}
