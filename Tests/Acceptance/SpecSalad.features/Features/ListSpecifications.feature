Feature: list specifications
	In order to specify the expectation of list contents in a natural language
	As a requirements writer
	I want to be able to use the syntax 'see a list of <item name> containing'

Scenario: a list containing syntax
	Given I am a list specification
	And I can see the list of available colours
	| colours |
	| Red     |
	| Green   |
	| Blue    |
	Then I should see the available colours list containing
	| colours |
	| Red     |
	| Green   |
	| Blue    |

Scenario: a list that does not contain syntax
	Given I am a list specification
	And I can see the list of available colours
	| colours |
	| Red     |
	| Green   |
	| Blue    |
	Then I should see the available colours list that does not contain
	| colours |
	| Pink    |
