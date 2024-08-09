namespace ServerApp.Data.Entities
{
    public class MarkVal
    {
        public Guid Id { get; set; }
        public virtual Guid ApplicationId { get; set; }
        public virtual ApplicationForm? Application { get; set; }
        public virtual Guid MarkId { get; set; }
        public virtual Mark? Mark { get; set; }
    }
}
