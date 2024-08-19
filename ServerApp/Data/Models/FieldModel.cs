using BlazorBootstrap;
using ServerApp.Data.Entities;

namespace ServerApp.Data.Models
{
    public class FieldModel
    {
        public FieldModel()
        {
            
        }
        public FieldModel(Field field)
        {
            if (field == null) throw new ArgumentNullException(nameof(field));
            Id = field.Id;
            ValId = (field.FieldVals.FirstOrDefault() ?? new FieldVal()).Id;
            Number = field.Number;
            Name = field.Name;
            EditGroup = field.EditGroup;
            Placeholder = field.Placeholder;
            ValueType = field.ValueType!.Name;
            SelectValues = field.SelectValues.Select(s => s.Value).ToArray();
            Value = field.FieldVals.FirstOrDefault()?.Value;
        }

        public FieldVal ToEntity()
        {
            return new FieldVal()
            {
                Id = this.ValId,
                FieldId = this.Id,
                Value = this.Value
            };
        }

        public Guid Id { get; set; }
        public Guid ValId { get; set; }
        public int? Number { get; set; }
        public string? Name { get; set; }
        public string? EditGroup { get; set; }
        public string? Placeholder { get; set; }
        public string? ValueType { get; set; }
        public string?[] SelectValues { get; set; } = [];
        public string? Value { get; set; }
    }
}