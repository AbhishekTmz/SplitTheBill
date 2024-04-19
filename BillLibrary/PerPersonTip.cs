namespace BillLibrary;

public class TipCalculatorPerPerson
{
    public static decimal PerPersonTipCalculator(decimal price, int NoOfStaff, float tipPercentage)
    {
        decimal FinalTip = price * (decimal)tipPercentage;

        decimal tipPerPerson = FinalTip / NoOfStaff;

        return tipPerPerson;
    }
}
