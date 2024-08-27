namespace Accounting.Core.Models
{
    public class AccountVM
    {
        public long Id { get; set; }
        public String AccountNumber { get; set; }
        public String Name { get; set; }
        public AccountTypeVM AccountType { get; set; }
        public String HasSubAccounts { get; set; }
        public String IsSubAccount { get; set; }
        public AccountVM? ParentAccount { get; set; }
        public NormalBalance NormalBalance { get; set; }
        public String IsActive { get; set; }
        public String IsPostingAccount { get; set; }
        public double OpeningBalance { get; set; }
        public double CurrentBalance { get; set; }
        public double FiscalYearOpeningBalance { get; set; }

        public List<AccountVM> SubAccounts { get; set; }

        public String AccountTypeAsString
        {
            get
            {
                return AccountType.Name;
            }
        }

        public AccountVM() : this(0, String.Empty, String.Empty, new AccountTypeVM(), "N", "N", null, NormalBalance.D, "Y", "Y")
        { }

        public AccountVM(long id, String name, String accountNumber, AccountTypeVM accountType, String hasSubAccounts, String isSubAccount, AccountVM? parentAccount, NormalBalance normalBalance, String isActive, String isPostingAccount)
        {
            Id = id;
            Name = name;
            AccountNumber = accountNumber;
            AccountType = accountType;
            HasSubAccounts = hasSubAccounts;
            IsSubAccount = isSubAccount;
            ParentAccount = parentAccount;
            NormalBalance = normalBalance;
            IsActive = isActive;
            IsPostingAccount = isPostingAccount;

            // TODO: Make service calls to calculate these when services are added.
            OpeningBalance = 0.00; //To be calculated in a service
            CurrentBalance = 0.00; //To be calculated in a service
            FiscalYearOpeningBalance = 0.00; //To be calculated in a service

            SubAccounts = new List<AccountVM>();
        }
    }
}
