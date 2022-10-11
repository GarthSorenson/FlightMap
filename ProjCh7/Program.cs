// Program.cs contains a driver for the HP Airlines program utilizing a FlightMap class
// Written by Garth Sorenson
// 10 Oct 2022

using System;
using System.IO;


namespace ProjCh7
{
    internal class Program
    {
        // Main is the beginning of the HP Airlines program.
        // It gets a City filename, a Flight filename, and a Request filename
        // from the user.  A FlightMap is created from the City file and the
        // Flight file.  Then each request in the Request file is handled.
        static void Main(string[] args)
        {
            string cityFilename, flightFilename, requestFilename;
            FlightMap map;
            StreamReader inStream;
            string[] fromToPair;
            string fromCity, toCity;

            // display greeting
            Console.WriteLine("HP Air!\n");
            Console.WriteLine("A flight map is generated based on the cities served listed in a City file");
            Console.WriteLine("and the direct flights listed in a Flight file.");
            Console.WriteLine("Then all requests listed in a Request file will be considered.");

            // get City filename
            cityFilename = GetValidFilename("City");

            // get Flight filename
            flightFilename = GetValidFilename("Flight");

            // create flight map based on City file and Flight file
            map = new FlightMap();
            map.read(cityFilename, flightFilename);

            // get Request filename, open file, and handle each request
            requestFilename = GetValidFilename("Request");
            inStream = new StreamReader(requestFilename);
            while (!inStream.EndOfStream)
            {
                fromToPair = inStream.ReadLine().Split(",");
                fromCity = fromToPair[0].Trim();
                toCity = fromToPair[1].Trim();
                Console.WriteLine($"\nRequest is to fly from {fromCity} to {toCity}.");
                if (map.isServed(fromCity) && map.isServed(toCity))
                {
                    if (map.isPath(fromCity, toCity))
                        Console.WriteLine($"HPAir flies from {fromCity} to {toCity}.");
                    else
                        Console.WriteLine($"Sorry. HPAir does not fly from {fromCity} to {toCity}.");
                }
                if (!map.isServed(fromCity))
                    Console.WriteLine($"Sorry. HPAir does not serve {fromCity}.");
                if (!map.isServed(toCity))
                    Console.WriteLine($"Sorry. HPAir does not serve {toCity}.");

            }
        }
        
        // Gets and returns a valid file's name from the user.
        public static string GetValidFilename(string which)
        {
            string filename;
 
            Console.Write($"\nEnter {which} filename: ");
            filename = Console.ReadLine().Trim();
            while (!File.Exists(filename))
            {
                Console.WriteLine(filename + " does not exist.  Try again.");
                Console.Write($"Enter {which} filename: ");
                filename = Console.ReadLine().Trim();
            }

            return filename;
        }
    }
}
