namespace App.Api;

public class Calculator : ISingletonCalculator, ITransientCalculator, IScopedCalculator
{
    public int Sum(int first, int second) => first + second;
}
