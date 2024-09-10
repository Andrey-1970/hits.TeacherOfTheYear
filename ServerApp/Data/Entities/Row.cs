namespace ServerApp.Data.Entities
{
    public class Row
    {
        public Guid Id { get; set; }
        public bool IsPrefilled { get; set; } = false;
        public int? Number { get; set; }
        public virtual Guid TableId { get; set; }
        public virtual Table? Table { get; set; }
        public virtual List<CellVal> CellVals { get; set; } = [];
    }
}
