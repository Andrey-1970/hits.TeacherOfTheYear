namespace ServerApp.Data.Entities
{
    public class EditBlock
    {
        public Guid Id { get; set; }
        public int Number { get; set; }
        public string? Name { get; set; }
        public virtual Guid TrackId { get; set; }
        public virtual Track? Track { get; set; }
        public virtual List<Field> Fields { get; set; } = [];
        public virtual List<Table> Tables { get; set; } = [];
    }
}
