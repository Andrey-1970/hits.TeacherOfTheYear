namespace ServerApp.Data.Entities
{
    public class ApplicationForm
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Guid Id { get; set; }
        public virtual Guid UserInfoId { get; set; }
        public virtual UserInfo UserInfo { get; set; }
        public virtual Guid TrackId { get; set; }
        public virtual Track Track { get; set; }
        public virtual List<MarkVal> MarkVals { get; set; } = [];
        public virtual List<FieldVal> FieldVals { get; set; } = [];
        public virtual List<CellVal> CellVals { get; set; } = [];
        public virtual List<BlockReviewStatus> BlockReviewStatusList { get; set; } = [];
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    }
}
