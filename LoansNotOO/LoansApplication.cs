namespace LoansNotOO
{
    // Application layer
    public class LoansApplication
    {
        public static void SaveLoan(Loan loan)
        {
            if (loan.LegalEntityType == LegalEntityType.NaturalPerson)
            {
                loan.TaxRate = 0.15m;
            }
            else
            {
                loan.TaxRate = 0.10m;
            }

            #region save to db

            // 

            #endregion save to db
        }
    }
}
