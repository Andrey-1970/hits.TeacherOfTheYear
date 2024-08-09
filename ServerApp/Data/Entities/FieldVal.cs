namespace ServerApp.Data.Entities
{
    public class FieldVal
    {
        public Guid Id { get; set; }
        public virtual Guid ApplicationId { get; set; }
        public virtual ApplicationForm? Application { get; set; }
        public virtual Guid FieldId { get; set; }
        public virtual Field? Field { get; set; }
    }
}
