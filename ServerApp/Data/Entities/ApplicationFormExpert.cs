using ServerApp.Data.Entities;

public class ApplicationFormExpert
{
    public Guid ApplicationFormId { get; set; }
    public virtual ApplicationForm ApplicationForm { get; set; }
    
    public Guid UserInfoId { get; set; }
    public virtual UserInfo UserInfo { get; set; }
}