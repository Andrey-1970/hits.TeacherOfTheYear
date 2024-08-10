using System.ComponentModel.DataAnnotations;

namespace ServerApp.Data.Entities
{
    public class Column
    {
        public Guid Id { get; set; }
        [MaxLength(255)] 
        public string? Name { get; set; } //todo: может быть не уникальным?
        public virtual Guid TableId { get; set; }
        public virtual Table? Table { get; set; }
        public virtual List<CellVal> CellVals { get; set; } = [];
        //todo: добавить поле для хранения типа вводимого значения
        //todo: поле для placeholder
        //todo: добавить поле значение по умолчанию
        //todo: добавить поле для ограничений редактирования пользователем
    }
}