using System.ComponentModel.DataAnnotations;

namespace ServerApp.Data.Entities
{
    public class Column
    {
        public Guid Id { get; set; }
        public int Number { get; set; }
        [MaxLength(255)] 
        public string? Name { get; set; }
        public virtual Guid ValueTypeId { get; set; }
        public virtual ValuesType? ValueType { get; set; }
        public virtual List<SelectValue> SelectValues { get; set; } = [];
        public virtual Guid TableId { get; set; }
        public virtual Table? Table { get; set; }
        public virtual List<CellVal> CellVals { get; set; } = [];
        //todo: поле для placeholder
        //todo: добавить поле значение по умолчанию
        //todo: добавить поле для ограничений редактирования пользователем
    }
}