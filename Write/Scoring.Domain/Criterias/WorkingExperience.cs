
using Framework.Core.Specifications;
using Scoring.Domain.Rules;

namespace Scoring.Domain.Criterias;

public class WorkingExperience : Specification<ApplicantCondition>
{
    public WorkingExperience(TimeSpan span)
    {
        this.Span = span;
    }
    public TimeSpan Span { get; set; }

    public override bool IsSatisfiedBy(ApplicantCondition value)
    {
        return value.HireDate.Add(Span) < DateTime.Now;
    }
}