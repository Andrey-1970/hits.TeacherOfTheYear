using System.ComponentModel.DataAnnotations.Schema;

namespace ServerApp.Data.Entities
{
    public class ApplicationFormExpert
    {
        public Guid Id { get; set; }
        
        public virtual Guid ApplicationFormId { get; set; }
        public virtual ApplicationForm ApplicationForm { get; set; }
        
        public virtual Guid UserInfoId { get; set; }
        public virtual UserInfo UserInfo { get; set; }
    }
}