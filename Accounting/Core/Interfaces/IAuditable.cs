namespace Accounting.Core
{
    public interface IAuditable
    {
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public String CreatedBy { get; set; }
        public String ModifiedBy { get; set; }
    }
}
