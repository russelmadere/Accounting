using Accounting.Core.Models;

namespace Accounting.Core.Domain
{
    public class AMAccount : IAuditable
    {
        public long Id { get; set; }
        public String Name { get; set; }
        public AccountTypeVM AccountType { get; set; }
        public String AccountNumber { get; set; }
        public bool HasSubAccounts { get; set; }
        public bool IsSubAccount { get; set; }
        public long? ParentAccountId { get; set; }

        public AMAccount? ParentAccount { get; set; }
        public List<AMAccount> SubAccounts { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }

        public AMAccount() : this(0, String.Empty, new AccountTypeVM(), String.Empty, false, false, null)
        { }

        public AMAccount(long id, String name, AccountTypeVM accountType, String accountNumber, bool hasSubAccounts, bool isSubAccount, long? parentAccountId)
        {
            Id = id;
            Name = name;
            AccountType = accountType;
            AccountNumber = accountNumber;
            HasSubAccounts = hasSubAccounts;
            IsSubAccount = isSubAccount;
            ParentAccountId = parentAccountId;

            SubAccounts = new List<AMAccount>();
        }
    }
}
