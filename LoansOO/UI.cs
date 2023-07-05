RetailLoan newRetailLoan = new RetailLoan()
{
    LegalEntityType = LegalEntityType.NaturalPerson,
    IdentificationNumber = "34111933991"
};

LoansApplication.SaveLoan(newRetailLoan);

CorporateLoan newCorporateLoan = new CorporateLoan()
{
    LegalEntityType = LegalEntityType.Corporate,
    IdentificationNumber = "3411193399"
};

LoansApplication.SaveLoan(newCorporateLoan);
