namespace ServerApp.Data.Entities
{
    public class CellVal
    {
        public Guid Id { get; set; }
        public virtual Guid ApplicationId { get; set; }
        public virtual ApplicationForm? Application { get; set; }
        public virtual Guid RowId { get; set; }
        public virtual Row? Row { get; set; }
        public virtual Guid ColumnId { get; set; }
        public virtual Column? Column { get; set; }
        //todo: поле для placeholder
    }
}
