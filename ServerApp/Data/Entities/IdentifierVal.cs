namespace ServerApp.Data.Entities
{
    public class IdentifierVal
    {
        public Guid Id { get; set; }
        public string? IdentifierId { get; set; }
        public string? Value1 { get; set; }
        public string? Value2 { get; set; }
        public Guid UserInfoId { get; set; }
        public virtual UserInfo? UserInfo { get; set; }
        public Guid IdentifierTypeId { get; set; }
        public virtual IdentifierType? IdentifierType { get; set; }
    }
}
