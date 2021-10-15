using System;
using System.Collections.Generic;
using System.Linq;

namespace Lamda
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Lamdapra> listPersonCity = new List<Lamdapra>();
            AddRecords(listPersonCity);

            //Retrieving_Top_TwoRecord_For_LessthanSixty
            Retrieving_Top_TwoRecord_For_LessthanSixty(listPersonCity);

            // checkingForTeenagerPersons
            CheckingForTeenagerPerson(listPersonCity);

            //Average_age_in_list
            Average_age_in_list(listPersonCity);


        }



        //UC 1
        private static void AddRecords(List<Lamdapra> listPersoncity)
        {
            listPersoncity.Add(new Lamdapra("202324093", "john", "12 Main Statement", "NewYork", 15));
            listPersoncity.Add(new Lamdapra("202324094", "SAM", "13 Main Statement", "NewYork", 25));
            listPersoncity.Add(new Lamdapra("202324095", "Elan", "14 Main Statement", "NewYork", 35));
            listPersoncity.Add(new Lamdapra("202324096", "Smith", "15 Main Statement", "NewYork", 45));
            listPersoncity.Add(new Lamdapra("202324097", "SAM", "16 Main Statement", "NewYork", 55));
            listPersoncity.Add(new Lamdapra("202324098", "Sue", "19 Main Statement", "NewYork", 65));
            listPersoncity.Add(new Lamdapra("202324098", "Winston", "89 Main Statement", "NewYork", 65));
            listPersoncity.Add(new Lamdapra("202324098", "Mac", "89 Main Statement", "NewYork", 85));
            listPersoncity.Add(new Lamdapra("202324098", "Sam", "89 Main Statement", "NewYork", 95));
        }

        //UC 2
        private static void Retrieving_Top_TwoRecord_For_LessthanSixty(List<Lamdapra> listPersonsInCity)
        {
            foreach (Lamdapra person in listPersonsInCity.FindAll(e => (e.Age < 68)).Take(2).ToList())
            {
                Console.WriteLine("Name :" + person.Name + " \t\t Age: " + person.Age);
            }
        }

        //UC3
        private static void CheckingForTeenagerPerson(List<Lamdapra> listPersonInCity)
        {
            if (listPersonInCity.Any(e => e.Age >= 13 && e.Age < 19))
            {
                Console.WriteLine("Yes, we have some teen-agers in the list");
            }
            else
            {
                Console.WriteLine("NO , we dont have any teen-agers in the list");
            }
        }

        //UC4
        private static void Average_age_in_list(List<Lamdapra> listPersonIncity)
        {

        }
    }
}
