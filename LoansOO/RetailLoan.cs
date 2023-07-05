namespace LoansOO
{
    public class RetailLoan : AbstractLoan
    {
        public override void SetTaxRate()
        {
            TaxRate = 0.15m;
        }
    }
}
