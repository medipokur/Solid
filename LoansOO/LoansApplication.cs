namespace LoansOO
{
    // take this class as an application layer class
    public class LoansApplication
    {
        public static void SaveLoan(AbstractLoan loan)
        {
            loan.SetTaxRate();

            #region Save To Db

            #endregion Save To Db
        }
    }
}
