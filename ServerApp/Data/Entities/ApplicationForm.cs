namespace ServerApp.Data.Entities
{
    public class ApplicationForm
    {
        public Guid Id { get; set; }
        public virtual Guid UserInfoId { get; set; }
        public virtual UserInfo? UserInfo { get; set; }
        public virtual Guid TrackId { get; set; }
        public virtual Track? Track { get; set; }
        public virtual List<MarkVal> MarkVals { get; set; } = [];
        public virtual List<FieldVal> FieldVals { get; set; } = [];
        public virtual List<CellVal> CellVals { get; set; } = [];
    }
}
