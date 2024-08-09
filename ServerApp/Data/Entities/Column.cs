namespace ServerApp.Data.Entities
{
    public class Column
    {
        public Guid Id { get; set; }
        public virtual Guid TableId { get; set; }
        public virtual Table? Table { get; set; }
        public virtual List<CellVal> CellVals { get; set; } = [];
    }
}
