using Accounting.Core.Models;

namespace Accounting.Core.Domain
{
    public class AMAccount : IAuditable
    {
        public long Id { get; set; }
        public String Name { get; set; }
        public String AccountNumber { get; set; }
        public byte AccountTypeId { get; set; }
        public String HasSubAccounts { get; set; }
        public String IsSubAccount { get; set; }
        public long? ParentAccountId { get; set; }
        public NormalBalance NormalBalance { get; set; }
        public String IsActive { get; set; }
        public String IsPostingAccount { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }

        public AMAccountType AccountType { get; set; }
        public AMAccount? ParentAccount { get; set; }
        public List<AMAccount> SubAccounts { get; set; }

        public AMAccount() : this(0, String.Empty, String.Empty, 0, "N", "N", null, NormalBalance.D, "Y", "Y")
        { }

        public AMAccount(long id, String name, String accountNumber, byte accountTypeId, String hasSubAccounts, String isSubAccount, long? parentAccountId, NormalBalance normalBalance, String isActive, String isPostingAccount)
        {
            Id = id;
            Name = name;
            AccountNumber = accountNumber;
            AccountTypeId = accountTypeId;
            HasSubAccounts = hasSubAccounts;
            IsSubAccount = isSubAccount;
            ParentAccountId = parentAccountId;
            NormalBalance = normalBalance;
            IsActive = isActive;
            IsPostingAccount = isPostingAccount;

            Created = DateTime.Now;
            Modified = DateTime.Now;
            CreatedBy = String.Empty;
            ModifiedBy = String.Empty;

            AccountType = new AMAccountType();
            SubAccounts = new List<AMAccount>();
        }
    }
}
