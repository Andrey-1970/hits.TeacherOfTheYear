namespace ServerApp.Data.Entities
{
    public class Mark
    {
        public Guid Id { get; set; }
        public int Number { get; set; }
        public string? Name { get; set; }
        public virtual Guid MarkBlockId { get; set; }
        public virtual MarkBlock? MarkBlock { get; set; }
        public virtual List<MarkVal> MarkVals { get; set; } = [];
    }
}
