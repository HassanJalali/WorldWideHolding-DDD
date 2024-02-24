using Framework.Core.Specifications;

namespace Scoring.Domain.Rules;

public class RuleCriteria : Specification<ApplicantCondition>
{
    public override bool IsSatisfiedBy(ApplicantCondition value)
    {
        return false;
    }
}