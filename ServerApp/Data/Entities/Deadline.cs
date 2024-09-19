using System.ComponentModel.DataAnnotations;

namespace ServerApp.Data.Entities
{
    public class Deadline : BaseEntity
    {
        public int Number { get; set; }
        [MaxLength(255)]
        public string? Name { get; set; }

        public DateTimeOffset Start { get; set; }
        public DateTimeOffset End { get; set; }
    }
}