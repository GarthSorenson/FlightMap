// City.cs contains a City class where a City contains a name
// It provides a compareTo method and supports ToString.
// Written by Garth Sorenson
// 11 Oct 2022

using System;

namespace ProjCh7
{
    internal class City
    {
        private string name;

        // Explicit value constructor receives a name for the City
        public City(string cityName)
        {
            name = cityName;
        }

        // compareTo checks to see if the two City names are equal
        public bool compareTo(City destinationCity)
        {
            return name == destinationCity.name;
        }

        // ToString simply returns the name
        public override string ToString()
        {
            return name;
        }
    }
}
