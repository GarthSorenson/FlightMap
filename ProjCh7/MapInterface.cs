﻿// MapInterface.cs contains the interface for the Map class of the HPAir problem
// Written by Garth Sorenson
// 10 Oct 2022

using System;

namespace ProjCh7
{
    internal interface MapInterface
    {
        //public Map();
        // Creates an empty flight map

        public void read(string CityFileName, string flightFileName);
        // Read flight information into the flight map

        public void display();
        // Displays flight information

        public void displayAllCities();
        // Displays the names of all cities that HPAir serves

        public void displayAdjacentCities(City aCity);
        // Displays all cities that are adjacent to a given city.

        public void markVisited(City aCity);
        // Marks a city as visited

        public City getNextCity(City aCity);
        // Returns the next unvisited city adjacent to a City


        public void unvisitAll();
        // Clears marks on all cities

        public bool isVisited(City aCity);
        // Determines whether a city was visited.

        public void insertAdjacent(City aCity, City adjCity);
        // Inserts a city adjacent to another city in a flight map.

        public bool isServed(City aCity);
        // Determines if a given city is served.

        public bool isPath(City originCity, City destinationCity);

    }
}
