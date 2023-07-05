namespace LoansOO
{
    public abstract class AbstractLoan
    {
        public LegalEntityType LegalEntityType { get; set; }

        public string IdentificationNumber { get; set; }

        public decimal TaxRate { get; set; }

        public abstract void SetTaxRate();
    }

    /// <summary>
    /// Yasal Kişilik Türü (gerçek kişi, kurumsal, kobi)
    /// </summary>
    public enum LegalEntityType
    {
        /// <summary>
        /// Gercek Kişi
        /// </summary>
        NaturalPerson = 1,

        /// <summary>
        /// Kurumsal
        /// </summary>
        Corporate = 2,

        /// <summary>
        /// KOBİ
        /// </summary>
        SME = 3
    }
}
