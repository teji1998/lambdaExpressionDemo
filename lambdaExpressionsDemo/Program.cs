using System;
using System.Collections.Generic;
using System.Linq;

namespace lambdaExpressionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to world of lambda expression !!!!!");
            //To create a list
            List<Person> personInCity = new List<Person>();
            AddingRecords(personInCity);
            ToGetTopTwoRecordsLessThanSixty(personInCity);
            TeenageAge(personInCity);
            AverageAge(personInCity);
            ToCheckNameExistence(personInCity);
            ToSkipRecords(personInCity);
            ToRemoveANameFromRecord(personInCity);
        }

        /// <summary>
        /// To add records in a list
        /// </summary>
        /// <param name="personInCity"></param>
        public static void AddingRecords(List<Person> personInCity)
        {
            personInCity.Add(new Person("102", "Harry", "London", 23));
            personInCity.Add(new Person("34", "Ron", "Toronto", 12));
            personInCity.Add(new Person("324", "Luna", "Seoul", 8));
            personInCity.Add(new Person("19", "Draco", "Russia", 72));
            personInCity.Add(new Person("15", "snape", "Hogwarts", 150));
           
        }

        /// <summary>
        /// To get top two records whose age is less than sixty
        /// </summary>
        /// <param name="personInCity"></param>
        private static void ToGetTopTwoRecordsLessThanSixty(List<Person> personInCity)
        {
            Console.WriteLine("====================================================");
            foreach (Person person in personInCity.FindAll(ageLimit => ageLimit.Age < 60).Take(2).ToList()) 
                {
                    Console.WriteLine("Name: " + person.Name + " Age: " + person.Age);
                }
            
        }

        /// <summary>
        /// To find if the records consist of teenage age people
        /// </summary>
        /// <param name="personInCity"></param>
        private static void TeenageAge(List<Person>personInCity)
        {
            Console.WriteLine("====================================================");
            if (personInCity.Any(teenAge => (teenAge.Age >= 13 && teenAge.Age < 19)))
            {
                Console.WriteLine("Teenagers are present");
            }
            else
            {
                Console.WriteLine("Teenagers are absent");
            }
        }

        /// <summary>
        /// To find the average of all the age of the records in the list
        /// </summary>
        /// <param name="personInCity"></param>
        private static void AverageAge(List<Person>personInCity)
        {
            double averageAge = personInCity.Average(avgAge => avgAge.Age);
            Console.WriteLine("====================================================");
            Console.WriteLine("The average of the age of the people in the list : " +averageAge);
        }

        /// <summary>
        /// To check if a name exists or not
        /// </summary>
        /// <param name="personInCity"></param>
        private static void ToCheckNameExistence(List<Person> personInCity)
        {
            Console.WriteLine("====================================================");
            if (personInCity.Exists(e => e.Name == "Draco"))
            {
                Console.WriteLine("The name exists !!!");
            }
            else
            {
                Console.WriteLine("The name doesn't exist !!!");
            }
        }

        /// <summary>
        /// To skip records where age is less than 60
        /// </summary>
        /// <param name="personInCity"></param>
        private static void ToSkipRecords(List<Person> personInCity)
        {
            Console.WriteLine("====================================================");
            foreach (Person person in personInCity.SkipWhile(s => s.Age < 60))
            {
                Console.WriteLine("Name is " + person.Name + " and age is " + person.Age  );
            }
        }

        /// <summary>
        /// To remove a name from a record
        /// </summary>
        /// <param name="personInCity"></param>
        private static void ToRemoveANameFromRecord (List<Person> personInCity)
        {
            Console.WriteLine("====================================================");
            personInCity.RemoveAll(s => s.Name == "Harry");
            Console.WriteLine("The name has been removed ");
            if (!personInCity.Exists(e => e.Name == "Harry")) {
                Console.WriteLine("Name does not exist !!!");
            }
            else
            {
                Console.WriteLine("Name is stil present!");
            }
        }

    }
}
