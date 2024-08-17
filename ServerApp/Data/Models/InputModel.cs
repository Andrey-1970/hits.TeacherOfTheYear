using System.ComponentModel.DataAnnotations;

namespace ServerApp.Data.Models
{
    public class InputModel
    {
        public Guid Id { get; set; }
        public int? Number { get; set; }
        public string? Name { get; set; }
        public string? Value { get; set; }
    }
}
