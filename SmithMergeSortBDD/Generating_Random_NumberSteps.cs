using NUnit.Framework;
using SmithMergeSortUI.MergeSort.ForSmith;
using SmithMergeSortUI;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace SmithMergeSortBDD
{
    [Binding]
    public class Generating_Random_NumberSteps
    {

        MergeSort<int> SortInParallel = new MergeSort<int>();
        MockRamdomNumber MockTestData = new MockRamdomNumber();
        RandNumberGenerator randomGenerator = new RandNumberGenerator();
        List<int> generatedrandomnumber = new List<int>();

        [Given(@"That no list/array of random numbers have been entered into the text box")]
        public void GivenThatNoListArrayOfRandomNumbersHaveBeenEnteredIntoTheTextBox()
        {
            Assert.Pass();
        }

        [When(@"I click the Generate button")]
        public void WhenIClickTheGenerateButton()
        {
            randomGenerator.GenerateRandomNumber(1, 1000);
            Assert.IsTrue(generatedrandomnumber.Count > 0);
        }

        [Then(@"the result should show on a generated list of random numbers")]
        public void ThenTheResultShouldShowOnTheScreenAGeneratedListOfRandomNumbers()
        {
            if (generatedrandomnumber.Count > 0)
            {
                Assert.Pass(System.String.Join(",", generatedrandomnumber));
            }
            else
            {
                Assert.Fail();
            }
        }

    }
}
