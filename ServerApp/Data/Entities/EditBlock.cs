using System.ComponentModel.DataAnnotations;

namespace ServerApp.Data.Entities
{
    public class EditBlock
    {
        public Guid Id { get; set; }
        public int Number { get; set; }
        [MaxLength(255)] 
        public string? Name { get; set; }
        public virtual List<Track> Tracks { get; set; } = [];
        public virtual List<Field> Fields { get; set; } = [];
        public virtual List<Table> Tables { get; set; } = [];
        public virtual List<EditBlockStatus> EditBlockStatusList { get; set; } = [];
    }
}
