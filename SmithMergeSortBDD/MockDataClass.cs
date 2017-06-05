using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmithMergeSortBDD
{
    public class MockRamdomNumber
    {
        private List<int> _ListOfMockRandomNumbers;
        private List<int> _ListOfMockSortedNumbers;


        public List<int> ListOfMockRandomNumbers
        {
            get {
                    return _ListOfMockRandomNumbers;
                }

            set {
                   int[] mocnumbers = new int[] {1,371,705,555,255,297,863,590,353,324,631,956,84,31,813,678,81,972,12};
                    _ListOfMockRandomNumbers = mocnumbers.ToList();
                }
        }

        public List<int> ListOfMockSortedNumbers
        {
            get {
                    return _ListOfMockSortedNumbers;
                }

            set {
                   int[] sortednumbers = new int[] { 1, 12, 31, 81, 84, 255, 297, 324, 353, 371, 555, 590, 631, 678, 705, 813, 863, 956, 972 };
                    _ListOfMockSortedNumbers = sortednumbers.ToList();
                }
        }
    }
}

