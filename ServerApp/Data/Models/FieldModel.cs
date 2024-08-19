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
            ArgumentNullException.ThrowIfNull(field);
            Id = field.Id;
            Number = field.Number;
            Name = field.Name;
            EditGroup = field.EditGroup;
            Placeholder = field.Placeholder;
            ValueType = field.ValueType!.Name;
            SelectValues = field.SelectValues.Select(s => s.Value).ToArray();
            Value = field.FieldVals.FirstOrDefault()?.Value;
        }

        public Field ToEntity()
        {
            if (Number == null) throw new InvalidOperationException("Number cannot be null.");
            
            return new Field
            {
                Id = this.Id,
                Number = (int)this.Number,
                Name = this.Name
            };
            //todo: что делать с Value?
        }

        public Guid Id { get; set; }
        public int? Number { get; set; }
        public string? Name { get; set; }
        public string? EditGroup { get; set; }
        public string? Placeholder { get; set; }
        public string? ValueType { get; set; }
        public string?[] SelectValues { get; set; } = [];
        public string? Value { get; set; }
    }
}