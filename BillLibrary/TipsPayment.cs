namespace BillLibrary;

public class CalculateTipAmount
{
    public static Dictionary<string, decimal> CalculateTipAmounts(Dictionary<string, decimal> FinalAmount, float tipPercent)
    {
        decimal totalCost = 0;
        foreach (var x in FinalAmount.Values)
        {
            totalCost += x;
        }

        Dictionary<string, decimal> tipShare = new Dictionary<string, decimal>();
        foreach (var x in FinalAmount)
        {
            decimal tipAmount = Decimal.Round(x.Value * (decimal)tipPercent, 2);
            tipShare[x.Key] = tipAmount;
        }

        return tipShare;
    }
}
