namespace ServerApp.Data.Entities
{
    public class IdentifierType
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public bool NeedValue1 { get; set; } = true;
        public bool NeedValue2 { get; set; } = true;
        public virtual List<IdentifierVal> IdentifierVals { get; set; } = [];
    }
}
