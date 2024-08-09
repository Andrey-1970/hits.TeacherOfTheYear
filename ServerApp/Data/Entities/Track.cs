namespace ServerApp.Data.Entities
{
    public class Track
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public virtual List<MarkBlock> MarkBlocks { get; set; } = [];
        public virtual List<EditBlock> EditBlocks { get; set; } = [];
        public virtual List<ApplicationForm> Applications { get; set; } = [];
    }
}
