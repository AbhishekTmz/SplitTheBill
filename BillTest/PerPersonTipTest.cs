using BillLibrary;

namespace BillTest;

public class TipCalculatorTests
{
    [TestMethod]
    public void CalculateTipPerPersonWhenNumberOFstaff5()
    {
        var result = TipCalculatorPerPerson.PerPersonTipCalculator(400,5,10f);
        Assert.AreEqual(8, result);
    }

    [TestMethod]
    public void calculateTipPerPersonWhenNumberOFstaff3()
    {
        var result = TipCalculatorPerPerson.PerPersonTipCalculator(9000,3,15f);
        Assert.AreEqual(8, result);

    }

    [TestMethod]
    public void CalculateWhenBill0()
    {
        var result = TipCalculatorPerPerson.PerPersonTipCalculator(0,3,15f);
        Assert.AreEqual(0, result);
    }
}
