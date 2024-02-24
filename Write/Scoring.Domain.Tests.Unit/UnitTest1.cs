using FluentAssertions;
using Scoring.Domain.Criterias;
using Scoring.Domain.Rules;

namespace Scoring.Domain.Tests.Unit;

public class RuleTests
{
    [Fact]
    public void score_gets_calculated_on_working_experience()
    {
        var applicant = new ApplicantCondition()
        {
            HireDate = new DateTime(2018, 01, 01)
        };

        var workingExperience = new WorkingExperience(TimeSpan.FromDays(365));
        var rule = new Rule(1, "more than 2 years experience", workingExperience);
        rule.SetCalculation(CalculationStarategy.IncreasePointsTo(1));

        var points = rule.Calculate(applicant);

        points.Should().Be(1);
    }
}