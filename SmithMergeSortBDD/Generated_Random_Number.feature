Feature: Generating_Random_Number
	GENERATES A LIST/ARRAY OF RANDOM NUMBERS, AND USES THE MERGE SORT ALGORITHM TO PERFORM AN ASCENDING SORT OF THE ELEMENTS.

	In order to merge sort a list of random number
	As a user
	I want to generate a list of random number an make it sort ascending.

@mytag
Scenario: Generate a valid List/Array of Random numbers
	Given That no list/array of random numbers have been entered into the text box
	When I click the Generate button
	Then the result should show on a generated list of random numbers

