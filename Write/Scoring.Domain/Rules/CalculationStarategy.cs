namespace Scoring.Domain.Rules;

public class CalculationStarategy
{
    public static CalculationStarategy None = new CalculationStarategy(0);
    private CalculationStarategy(int value)
    {
        Value = value;
    }
    public int Value { get; private set; }

    public static CalculationStarategy IncreasePointsTo(int value)
    {
        return new CalculationStarategy(value);
    }

    public static CalculationStarategy DecreasePointsTo(int value)
    {
        return new CalculationStarategy(value * -1);
    }
}