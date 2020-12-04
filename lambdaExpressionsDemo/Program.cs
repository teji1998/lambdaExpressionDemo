﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace lambdaExpressionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to world of lambda expression !!!!!");
            List<Person> personInCity = new List<Person>();
            AddingRecords(personInCity);
            ToGetTopTwoRecordsLessThanSixty(personInCity);
            TeenageAge(personInCity);
        }
        public static void AddingRecords(List<Person> personInCity)
        {
            personInCity.Add(new Person("102", "Harry", "London", 23));
            personInCity.Add(new Person("34", "Ron", "Toronto", 12));
            personInCity.Add(new Person("324", "Luna", "Seoul", 8));
            personInCity.Add(new Person("19", "Draco", "Russia", 72));
            personInCity.Add(new Person("15", "snape", "Hogwarts", 150));
           
        }
        private static void ToGetTopTwoRecordsLessThanSixty(List<Person> personInCity)
        {
            foreach (Person person in personInCity.FindAll(ageLimit => ageLimit.Age < 60).Take(2).ToList()) 
                {
                    Console.WriteLine("Name: " + person.Name + " Age: " + person.Age);
                }
            
        }
        private static void TeenageAge(List<Person>personInCity)
        {
            if (personInCity.Any(teenAge => (teenAge.Age >= 13 && teenAge.Age < 19)))
            {
                Console.WriteLine("Teenagers are present");
            }
            else
            {
                Console.WriteLine("Teenagers are absent");
            }
        }
    }
}