using System;
using System.Collections.Generic;

namespace Tourists
{
    class Program
    {
        static List<City> cities = new List<City>();

        static void Main(string[] args)
        {
            CityDB();
            Console.WriteLine("Welcome to the Trip Cost Calculator!");
            Console.WriteLine("Please enter your departure city:");
            string departureCity = Console.ReadLine();
            Console.WriteLine("Please enter up to 3 cities you would like to visit:");
            string[] citiesToVisit = new string[3];
            for (int i = 0; i < citiesToVisit.Length; i++)
            {
                citiesToVisit[i] = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(citiesToVisit[i]))
                {
                    break;
                }
            }
            Console.WriteLine("Please enter the cost of your trip:");
            double tripCost = Convert.ToDouble(Console.ReadLine());

            double totalCost = tripCost;
            bool isFromEU = !(departureCity == "Madrid" || departureCity == "Kishinev" || departureCity == "London");

            foreach (string city in citiesToVisit)
            {
                if (city == "Vatican")
                {
                    totalCost += tripCost * 0.5;
                }
                else if (city == "Berlin")
                {
                    totalCost += tripCost * 0.13;
                }
                else if (city == "Palermo")
                {
                    if (departureCity == "London")
                    {
                        totalCost += tripCost * 0.07;
                    }
                    else if (departureCity == "Kishinev")
                    {
                        totalCost += tripCost * 0.11;
                    }
                }
                else if (city == "Riga")
                {
                    if (departureCity == "Paris")
                    {
                        totalCost += tripCost * 0.09;
                    }
                }
                else if (!isFromEU)
                {
                    totalCost += tripCost * 0.04;
                }
            }

            Console.WriteLine("The total cost of your trip is: $" + totalCost);
        }

        public static void CityDB()
        {
            City city1 = new City();
            city1.Name = "Берлин";
            city1.Price = 399;
            city1.Transit = 175;
            cities.Add(city1);

            City city2 = new City();
            city2.Name = "Прага";
            city2.Price = 300;
            city2.Transit = 270;
            cities.Add(city2);

            City city3 = new City();
            city3.Name = "Париж";
            city3.Price = 350;
            city3.Transit = 220;
            cities.Add(city3);

            City city4 = new City();
            city4.Name = "Рига";
            city4.Price = 250;
            city4.Transit = 170;
            cities.Add(city4);

            City city5 = new City();
            city5.Name = "Лондон";
            city5.Price = 390;
            city5.Transit = 270;
            cities.Add(city5);

            City city6 = new City();
            city6.Name = "Ватикан";
            city6.Price = 500;
            city6.Transit = 350;
            cities.Add(city6);

            City city7 = new City();
            city7.Name = "Палерио";
            city7.Price = 230;
            city7.Transit = 150;
            cities.Add(city7);

            City city8 = new City();
            city8.Name = "Варшава";
            city8.Price = 300;
            city8.Transit = 190;
            cities.Add(city8);

            City city9 = new City();
            city9.Name = "Кишинёв";
            city9.Price = 215;
            city9.Transit = 110;
            cities.Add(city9);

            City city10 = new City();
            city10.Name = "Мадрид";
            city10.Price = 260;
            city10.Transit = 190;
            cities.Add(city10);

            City city11 = new City();
            city11.Name = "Будапешт";
            city11.Price = 269;
            city11.Transit = 230;
            cities.Add(city11);
        }
    }
}

