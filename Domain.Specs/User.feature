Feature: User
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Basic Creation
	Given a username of "marko"
	When I create a User
	Then the username should be "marko"
