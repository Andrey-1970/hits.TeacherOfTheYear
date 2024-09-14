using System.ComponentModel.DataAnnotations;

namespace ServerApp.Data.Entities
{
    public class FieldVal
    {
        public Guid Id { get; set; }
        [MaxLength(512)] 
        public string? Value { get; set; }
        public virtual Guid ApplicationId { get; set; }
        public virtual ApplicationForm? Application { get; set; }
        public virtual Guid FieldId { get; set; }
        public virtual Field? Field { get; set; }
    }
}
