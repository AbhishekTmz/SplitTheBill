using BillLibrary;

namespace BillTest;

[TestClass]
public class CalculateTipAmountTest
{
    [TestMethod]
    public void CalculateTipShare()
    {
        // Arrange
       var TipCalc = new CalculateTipAmount();
       var totaltip = new Dictionary<string , decimal>()
       {
            {"Tashi", 100},
            {"Dawa", 100},
            {"Priskila", 100}
        };
        float tipPercentage = 0.15f;

        // Act
        var result = TipCalculator.CalculateTipAmounts(FinalAmount, tipPercent);

        // Assert
        Assert.AreEqual(15, result["Tashi"]);
        Assert.AreEqual(15, result["Dawa"]);
        Assert.AreEqual(15, result["Priskila"]);
        
    }


    [TestMethod]
    public void CalculateTipWithdifferentPercent()
    {
        // Arrange
       var TipCalc = new CalculateTipAmount();
       var totaltip = new Dictionary<string , decimal>()
        {
            {"Motey", 8000},
            {"Bheda",8000},
            {"Anda", 8000}
        };
        float tipPercentage = 0.12f;

        // Act
        var result = TipCalculator.CalculateTipAmounts(FinalAmount, tipPercent);

        // Assert
       Assert.AreEqual(960, result["Motey"]);
        Assert.AreEqual(960, result["Bheda"]);
        Assert.AreEqual(960, result["Anda"]);
        
    }

    [TestMethod]
    public void CalculateTipWhenAmountZero()
    {
        // Arrange
          var TipCalc = new CalculateTipAmount();
          var totaltip = new Dictionary<string , decimal>()
          {
            {"Motey", 400},
            {"Bheda",400},
            {"Anda", 400}
          };
          float tipPercentage = 0f;
        
        // Act
        var result = TipCalculator.CalculateTipAmounts(FinalAmount, tipPercentage);

        // Assert
     Assert.AreEqual(0, result["Motey"]);
     Assert.AreEqual(0, result["Bheda"]);
    Assert.AreEqual(0, result["Anda"]);
    }
}
