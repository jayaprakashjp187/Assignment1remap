using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class PlaceName
    {
        public void PlaceNameInCasing(string placeName)
        {
            
            string placeInUppercase = placeName.ToUpper();

            
            Console.WriteLine( "placeInUppercase");

            
            string placeInLowercase = placeName.ToLower();

            
            Console.WriteLine($"Place in Lowercase: {placeInLowercase}");
        }
    }
}
