using Framework.Core.Specifications;

namespace Scoring.Domain.Rules
{
    public class Rule
    {
        public Rule(int id, string title, Specification<ApplicantCondition> criteria)
        {
            Id = id;
            Title = title;
            Criteria = criteria;
            Calculation = CalculationStarategy.None;
        }
        public int Id { get; private set; }
        public string Title { get; private set; }
        public Specification<ApplicantCondition> Criteria { get; private set; }
        public CalculationStarategy Calculation { get; private set; }


        public void SetCalculation(CalculationStarategy calculation)
        {
            this.Calculation = calculation;
        }

        public int Calculate(ApplicantCondition applicant)
        {
            if (Criteria.IsSatisfiedBy(applicant))
                return this.Calculation.Value;

            return 0;
        }
    }
}
