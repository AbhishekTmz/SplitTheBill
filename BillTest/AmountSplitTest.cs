using BillLibrary;

namespace BillTest
{
    [TestClass]
public class AmountSplitTest{
    [TestMethod]
    public void AmountTest()
    {
        var Amount = new SpAmount();
        var splittedAmount = Amount.splittedAmount(500 , 5);
        Assert.AreEqual(100 , splittedAmount);
    }
    [TestMethod]
    public void ZeroAmount()
    {
        var Amount = new SpAmount();
        var splittedAmount = Amount.splittedAmount(0 , 10);
        Assert.AreEqual(0 , splittedAmount);
    }
      [TestMethod]
    public void ThousandAmount()
    {
        var Amount = new SpAmount();
        var splittedAmount = Amount.splittedAmount(1000, 10);
        Assert.AreEqual(10 , splittedAmount);
    }
}
}