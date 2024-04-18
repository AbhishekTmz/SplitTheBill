namespace BillLibrary
{
    public class AmountSplit{
        public decimal SpAmount(decimal Amount , int numberOfPeople){
            if (Amount > 0 && numberOfPeople > 0) {
            return Amount / numberOfPeople;
            }
            else{
                return 0;
            }
        }
    }
}