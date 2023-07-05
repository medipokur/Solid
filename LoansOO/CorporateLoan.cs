namespace LoansOO
{
    public class CorporateLoan : AbstractLoan
    {
        public override void SetTaxRate()
        {
            TaxRate = 0.10m;
        }
    }
}
