using System;
using System.Collections.Generic;

namespace Lamda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Lamdapra> listPersonCity = new List<Lamdapra>();
            AddRecords(listPersonCity);

            

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
    }
}
