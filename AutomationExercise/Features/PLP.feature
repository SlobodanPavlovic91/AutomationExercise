Feature: PLP
	As a user i want to be able to search a product
	So i can see the list of all products with searched value
@mytag
Scenario: User can search a product
	Given user opens products page
	When user enters name of the product in the search bar
		And click on the magnifying glass icon
	Then user will be able to see searched value on page "Searched Products"