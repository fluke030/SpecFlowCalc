Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowCalculator.Specs/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Add two numbers
Given I have provided 70 and 20 as the inputs
When I press add
Then the result should be 90
 
Scenario: Substract two numbers
Given I have provided 70 and 20 as the inputs
When I press substract
Then the result should be 50
 
Scenario: Multiply two numbers
Given I have provided 70 and 20 as the inputs
When I press multiply
Then the result should be 1400
 
Scenario: Divide two numbers
Given I have provided 70 and 20 as the inputs
When I press divide
Then the result should be 3.5
 
Scenario: SquareRoot of number
Given I have provided 70 as input
When I press squareroot
Then the result should be 8.37

Scenario: Modulo of a number
Given I have provided 70 and 30 as the inputs
When I press modulo
Then the result should be 10

Scenario: Floor of a number
Given I have provided 8.5 as input
When I press floor
Then the result should be 8

Scenario: Ceiling of a number
Given I have provided 8.5 as input
When I press ceiling
Then the result should be 9