namespace Accounting.Core.Models
{
    public class AccountVM
    {
        public long Id { get; set; }
        public String Name { get; set; }
        public AccountTypeVM AccountType { get; set; }
        public String AccountNumber { get; set; }
        public bool HasSubAccounts { get; set; }
        public bool IsSubAccount { get; set; }
        public long? ParentAccountId { get; set; }

        public AccountVM? ParentAccount { get; set; }
        public List<AccountVM> SubAccounts { get; set; }

        public AccountVM() : this(0, String.Empty, new AccountTypeVM(), String.Empty, false, false, null)
        { }

        public AccountVM(long id, String name, AccountTypeVM accountType, String accountNumber, bool hasSubAccounts, bool isSubAccount, long? parentAccountId)
        {
            Id = id;
            Name = name;
            AccountType = accountType;
            AccountNumber = accountNumber;
            HasSubAccounts = hasSubAccounts;
            IsSubAccount = isSubAccount;
            ParentAccountId = parentAccountId;

            SubAccounts = new List<AccountVM>();

        }
    }
}
