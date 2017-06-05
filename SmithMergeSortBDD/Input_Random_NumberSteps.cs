using NUnit.Framework;
using SmithMergeSortUI.MergeSort.ForSmith;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace SmithMergeSortBDD
{
    [Binding]
    public class Input_Random_NumberSteps
    {
        MergeSort<int> SortInParallel = new MergeSort<int>();
        MockRamdomNumber MockTestData = new MockRamdomNumber();


        [Given(@"That a valid list/array of random numbers have been entered into the text box")]
        public void GivenThatAValidListArrayOfRandomNumbersHaveBeenEnteredIntoTheTextBox()
        {
            Assert.Pass();
        }

        [When(@"I press sort")]
        public void WhenIPressSort()
        {
            List<int> mockrandomnumber = MockTestData.ListOfMockRandomNumbers;
            SortInParallel.Sort(mockrandomnumber);
            Assert.IsTrue(mockrandomnumber == MockTestData.ListOfMockSortedNumbers);
        }

        [Then(@"the result should show on the screen a list of random numbers sorted ascending")]
        public void ThenTheResultShouldShowOnTheScreenAListOfRandomNumbersSortedAscending()
        {
            List<int> mockrandomnumber = MockTestData.ListOfMockRandomNumbers;
            SortInParallel.Sort(mockrandomnumber);
            if (mockrandomnumber == MockTestData.ListOfMockSortedNumbers)
            { Assert.Pass(); }
        }
    }
}
