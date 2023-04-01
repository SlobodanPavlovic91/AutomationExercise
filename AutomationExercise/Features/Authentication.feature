Feature: Authentication
	As a user 
	I want to be able to authecticate to the app
	So i can work with restricted web app content

@msmoke
Scenario: User can log in
	Given user opens sign in page
		And user enters correct credentials
	When user submit login form
	Then user will be logged in

Scenario: User can sign up
	Given user opens sign in page
		And enters 'Slobodan' name and valid email address
		And clicks on sign SignUp button
	When user fills in all reqired fields
		And submits the signup form
	Then user will get 'Account Created!' success message
		And user will be logged in
