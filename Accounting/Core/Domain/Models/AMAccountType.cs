namespace Accounting.Core.Domain
{
    public class AMAccountType
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

        public List<AMAccount> Accounts { get; set; }

        public AMAccountType() : this(0, String.Empty, String.Empty, NormalBalance.D, String.Empty, "N", String.Empty, FinancialStatementType.BalanceSheet, 0, "N")
        { }

        public AMAccountType(byte id, String name, String code, NormalBalance normalBalance, String category, String isActive, String description, FinancialStatementType statementType, byte reportingSequence, String hasTaxImplications)
        {
            Id = id;
            Name = name;
            Code = code;
            NormalBalance = normalBalance;
            Category = category;
            IsActive = isActive;
            Description = description;
            StatementType = statementType;
            ReportingSequence = reportingSequence;
            HasTaxImplications = hasTaxImplications;

            Accounts = new List<AMAccount>();
        }
    }
}
