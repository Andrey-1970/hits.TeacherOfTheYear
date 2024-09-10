using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ServerApp.Data.Entities
{
    public class FeedBack
    {
        public FeedBack() { }
        public FeedBack(FeedBack feedback) 
        {
            ArgumentNullException.ThrowIfNull(feedback);
            Id = feedback.Id;
            Name = feedback.Name;
            Email = feedback.Email;
            Message = feedback.Message;
            Checked = feedback.Checked;

        }
        public FeedBack ToEntity()
        {
            return new FeedBack
            {
                Id = this.Id,
                Name = this.Name,
                Email = this.Email,
                Message = this.Message,
                Checked = this.Checked,
            };
        }
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Message { get; set; }
        public bool Checked { get; set; }
    }
}