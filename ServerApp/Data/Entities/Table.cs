﻿namespace ServerApp.Data.Entities
{
    public class Table
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public virtual Guid MarkBlockId { get; set; }
        public virtual MarkBlock? MarkBlock { get; set; }
        public virtual Guid EditBlockId { get; set; }
        public virtual EditBlock? EditBlock { get; set; }
        public virtual List<Row> Rows { get; set; } = [];
        public virtual List<Column> Columns { get; set; } = [];
    }
}
