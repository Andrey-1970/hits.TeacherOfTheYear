using System.ComponentModel.DataAnnotations;

namespace ServerApp.Data.Entities
{
    public class MarkVal
    {
        public Guid Id { get; set; }
        [MaxLength(255)] public string? Value { get; set; }
        //todo: тип вводимого значения
        public virtual Guid ApplicationId { get; set; }
        public virtual ApplicationForm? Application { get; set; }
        public virtual Guid MarkId { get; set; }
        public virtual Mark? Mark { get; set; }
    }
}
