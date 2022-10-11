// Map.cs contains the Map class for the HPAir problem.
// Originally written by Garth Sorenson
// 10 Oct 2022

using System;

namespace ProjCh7
{
    internal class Map : MapInterface
    {

        public bool isPath(City originCity, City destinationCity)
        {
            // ---------------------------------------------------
            // Determines whether a sequence of flights between two cities
            // exists. Nonrecursive stack version.
            // Precondition: originCity and destinationCity are the origin
            // and destination cities, respectively.
            // Postcondition: Returns true if a sequence of flights exists
            // from originCity to destinationCity, otherwise returns
            // false. Cities visited during the search are marked as
            // visited in the flight map.
            // Implementation notes: Uses a stack for the cities of a
            // potential path. Calls unvisitAll, markVisited, and
            // getNextCity.
            // ---------------------------------------------------
            StackReferenceBased stack = new StackReferenceBased();

            City topCity, nextCity;
            unvisitAll();  // clear marks on all cities

            // push origin city onto stack, mark it visited
            stack.push(originCity);
            markVisited(originCity);

            topCity = (City)(stack.peek());
            while (!stack.isEmpty() &&
                    (topCity.compareTo(destinationCity) != 0))
            {
                // loop invariant: stack contains a directed path
                // from the origin city at the bottom of the stack
                // to the city at the top of the stack

                // find an unvisited city adjacent to the city on
                // the top of the stack
                nextCity = getNextCity(topCity);

                if (nextCity == null)
                {
                    stack.pop();  // no city found; backtrack
                }
                else
                {                  // visit city
                    stack.push(nextCity);
                    markVisited(nextCity);
                }  // end if
                topCity = (City)stack.peek();
            }  // end while
            if (stack.isEmpty())
            {
                return false;  // no path exists
            }
            else
            {
                return true;   // path exists
            }  // end if*/
        }  // end isPath    
    }
}