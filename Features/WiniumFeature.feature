Feature: WiniumFeature
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
	Given I have entered <OperatorOne> into the Operator1
	And I have entered <OperatorTwo> into the Operator2
	When I press <Operator>
	Then the result should be <Result> on the screen

Scenarios: 
		| OperatorOne | OperatorTwo | Operator | Result |
		| 50          | 70          |   1		| 120	|
		| 10          | 1           |	2	    | 9	    |
		| 7           | 3           |	3	    | 21	|
		| 144         | 12          |	4       | 12	|