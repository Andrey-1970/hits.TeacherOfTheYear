using ServerApp.Data.Entities;

namespace ServerApp.Data.Models.EditModel
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
            Name = editBlock.Name;
        }

        public EditBlock ToEntity()
        {
            return new EditBlock
            {
                Id = this.Id,
                Name = this.Name
            };
        }

        public Guid Id { get; set; }
        public string? Name { get; set; } 
        public bool Status { get; set; }
    }
}