namespace LoansNotOO
{
    public class Loan
    {
        public LegalEntityType LegalEntityType { get; set; }

        public string IdentificationNumber { get; set; }

        public decimal TaxRate { get; set; }
    }

    public enum LegalEntityType
    {
        /// <summary>
        /// Gercek Kişi
        /// </summary>
        NaturalPerson = 1,

        /// <summary>
        /// Kurumsal
        /// </summary>
        Corporate = 2
    }
}
