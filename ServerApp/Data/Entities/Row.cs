namespace ServerApp.Data.Entities
{
    public class Row
    {
        public Guid Id { get; set; }
        public bool IsPrefilled { get; set; } = false;
        public virtual Guid TableId { get; set; }
        public virtual Table? Table { get; set; }
        public virtual List<CellVal> CellVals { get; set; } = [];
    }
}
