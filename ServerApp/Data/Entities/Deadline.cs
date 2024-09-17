using System.ComponentModel.DataAnnotations;

namespace ServerApp.Data.Entities
{
    public class Deadline : BaseEntity
    {
        public int Number { get; set; }
        [MaxLength(255)]
        public string? Name { get; set; }

        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }
}
