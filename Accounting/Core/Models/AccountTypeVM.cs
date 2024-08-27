namespace Accounting.Core
{
    public class AccountTypeVM
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public String Code { get; set; }
        public NormalBalance NormalBalance { get; set; }
        public String Category { get; set; }
        public String IsActive { get; set; }
        public String Description { get; set; }
        public FinancialStatementType StatementType { get; set; }
        public byte ReportingSequence { get; set; }
        public String HasTaxImplications { get; set; }

        public override String ToString()
        {
            return Name;
        }

        public AccountTypeVM() : this(0, String.Empty, String.Empty, NormalBalance.D, 0, "N", String.Empty, FinancialStatementType.BalanceSheet, 0, "N")
        { }

        public AccountTypeVM(byte id, String name, String code, NormalBalance normalBalance, byte categoryId, String isActive, String description, FinancialStatementType statementType, byte reportingSequence, String hasTaxImplications)
        {
            Id = id;
            Name = name;
            Code = code;
            NormalBalance = normalBalance;
            CategoryId = categoryId;
            IsActive = isActive;
            Description = description;
            StatementType = statementType;
            ReportingSequence = reportingSequence;
            HasTaxImplications = hasTaxImplications;
        }
    }
}
