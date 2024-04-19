using BillLibrary;

namespace BillTest
{
    [TestClass]
public class AmountSplitTest{
    [TestMethod]
    public void AmountTest500()
    {
        var Amount = new AmountSplit();
        var splittedAmount = Amount.SpAmount(500 , 5);
        Assert.AreEqual(100 , splittedAmount);
    }
    [TestMethod]
    public void ZeroAmount()
    {
        var Amount = new AmountSplit();
        var splittedAmount = Amount.SpAmount(0 , 10);
        Assert.AreEqual(0 , splittedAmount);
    }
      [TestMethod]
    public void ThousandAmount()
    {
        var Amount = new AmountSplit();
        var splittedAmount = Amount.SpAmount(1000, 10);
        Assert.AreEqual(100 , splittedAmount);
    }
}
}