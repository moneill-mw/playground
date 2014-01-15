Feature: User
	In order to ensure that basic user functionality is available
	As a consumer
	I want the user's name to be what it was at creation

@mytag
Scenario: Basic Creation
	Given a username of "erin"
	When I create a User
	Then the username should be "erin"
