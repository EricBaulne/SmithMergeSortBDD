Feature: Input_random_number
	INPUT A LIST OF RANDOM NUMBERS, AND USES THE MERGE SORT ALGORITHM TO PERFORM AN ASCENDING SORT OF THE LIST ELEMENTS.

	In order to merge sort a list of random number
	As a user
	I want to input a list of random number an make it sort ascending.

@mytag
Scenario: Input a valid List/Array of Random numbers
	Given That a valid list/array of random numbers have been entered into the text box
	When I press sort
	Then the result should show on the screen a list of random numbers sorted ascending

