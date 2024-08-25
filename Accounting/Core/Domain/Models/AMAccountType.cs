namespace Accounting.Core.Domain
{
    public class AMAccountType
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public NormalBalance NormalBalance { get; set; }

        public AMAccountType() : this(0, String.Empty, NormalBalance.D)
        { }

        public AMAccountType(byte id, String name, NormalBalance normalBalance)
        {
            Id = id;
            Name = name;
            NormalBalance = normalBalance;
        }
    }
}
