using Gherkin.Ast;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowCalculator.Specs.StepDefinitions;

[Binding]
public sealed class CalculatorStepDefinitions
{
    private readonly Calculator _calculator = new Calculator();
    private double _result;

    [Given(@"I have provided (.*) and (.*) as the inputs")]
    public void GivenIHaveProvidedAndAsTheInputs(int p0, int p1)
    {
        _calculator.FirstNumber = p0;
        _calculator.SecondNumber = p1;
    }

    [When(@"I press add")]
    public void WhenIPressAdd()
    {
        _result = _calculator.Add();
    }

    [When(@"I press substract")]
    public void WhenIPressSubstract()
    {
        _result = _calculator.Subtract();
    }

    [When(@"I press multiply")]
    public void WhenIPressMultiply()
    {
        _result = _calculator.Multiply();
    }

    [When(@"I press divide")]
    public void WhenIPressDivide()
    {
        _result = _calculator.Divide();
    }

    [Then(@"the result should be (.*)")]
    public void ThenTheResultShouldBe(double p0)
    {
        _result.Should().Be(p0);
    }

    [Given(@"I have provided (.*) as input")]
    public void GivenIHaveProvidedAsInput(double p0)
    {
        _calculator.FirstNumber = p0;
    }

    [When(@"I press squareroot")]
    public void WhenIPressSquareroot()
    {
        _result = _calculator.SquareRoot();
    }

    [When(@"I press modulo")]
    public void WhenIPressModulo()
    {
        _result = _calculator.Modulo();
    }

    [When(@"I press floor")]
    public void WhenIPressFloor()
    {
        _result = _calculator.Floor();
    }

    [When(@"I press ceiling")]
    public void WhenIPressCeiling()
    {
        _result = _calculator.Ceiling();
    }
}