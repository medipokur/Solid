Loan newRetailLoan = new Loan()
{
    LegalEntityType = LegalEntityType.NaturalPerson,
    IdentificationNumber = "34111933991"
};

LoansApplication.SaveLoan(newRetailLoan);

Loan newCorporateLoan = new Loan()
{
    LegalEntityType = LegalEntityType.Corporate,
    IdentificationNumber = "3411193399"
};

LoansApplication.SaveLoan(newCorporateLoan);
