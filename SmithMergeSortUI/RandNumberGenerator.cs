using System;
using System.Collections.Generic;

namespace SmithMergeSortUI
{
    public class RandNumberGenerator
    {
        public List<int> GenerateRandomNumber(int min, int max)
        {
            var randomObj = new Random();
            var rtnlist = new List<int>();

            for (int i = min; i < 20; i++)
            {
                rtnlist.Add(randomObj.Next(max));
            }

            return rtnlist;
        }
    }
}
