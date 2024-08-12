using System.ComponentModel.DataAnnotations;

namespace ServerApp.Data.Entities
{
    public class Field
    {
        public Guid Id { get; set; }
        [MaxLength(400)] 
        public string? Name { get; set; }

        public virtual List<MarkBlock> MarkBlocks { get; set; } = [];
        public virtual Guid EditBlockId { get; set; }
        public virtual EditBlock? EditBlock { get; set; }
        public virtual List<FieldVal> FieldVals { get; set; } = [];
        public virtual List<Mark> Marks { get; set; } = [];
        //todo: добавить поле тип вводимого значения
        //todo: поле для placeholder
        //todo: значение по умолчанию
    }
}
