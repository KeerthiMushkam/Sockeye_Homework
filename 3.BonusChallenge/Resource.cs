using System.Collections.Generic;

namespace _3.BonusChallenge_1
{
    public class Resource
    {
        public IEnumerable<string> SimpleList => new List<string>
            {"Kyoto", "London", "Portland", "Tokyo", "Wichita", "Donlon", "Anchorage"};

        public IEnumerable<string> HarderList => new List<string> 
            {"care", "team","Twelve plus One", "folk", "simple race", "truth", "race", "real", "meats", "aloud", "common", "super", "math", "react", "eleven plus two", "care impels" };
    }
}