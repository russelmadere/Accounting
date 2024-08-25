namespace Accounting.Core
{
    public class AccountTypeVM
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public NormalBalance NormalBalance { get; set; }

        public override String ToString()
        {
            return Name;
        }

        public AccountTypeVM() : this(0, String.Empty, NormalBalance.D)
        { }

        public AccountTypeVM(byte id, String name, NormalBalance normalBalance)
        {
            Id = id;
            Name = name;
            NormalBalance = normalBalance;
        }
    }
}
