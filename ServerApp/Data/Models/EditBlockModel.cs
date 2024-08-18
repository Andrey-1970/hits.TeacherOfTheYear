using ServerApp.Data.Entities;

namespace ServerApp.Data.Models
{
    public class EditBlockModel
    {
        public EditBlockModel()
        {
            
        }
        public EditBlockModel(EditBlock editBlock)
        {
            if (editBlock == null) throw new ArgumentNullException(nameof(editBlock));
            Id = editBlock.Id;
            Number = editBlock.Number;
            Name = editBlock.Name;
        }

        public EditBlock ToEntity()
        {
            if (Number == null) throw new InvalidOperationException("Number cannot be null.");
            
            return new EditBlock
            {
                Id = this.Id,
                Number = (int)this.Number,
                Name = this.Name
            };
        }

        public Guid Id { get; set; }
        public int? Number { get; set; }
        public string? Name { get; set; }  
    }
}