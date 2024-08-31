using ServerApp.Data.Entities;

namespace ServerApp.Data.Models.ReviewModel;

public class UserInfoModel
{
    public UserInfoModel()
    {
        
    }

    public UserInfoModel(UserInfo userInfo)
    {
        Id = userInfo.Id;
        var fullName = userInfo.Applications
            .SelectMany(app => app.FieldVals)
            .FirstOrDefault(f => f.Field!.Name == "ФИО");
        if (fullName != null)
        {
            FullName = fullName.Value;
        }
        var phoneField = userInfo.Applications
            .SelectMany(app => app.FieldVals)
            .FirstOrDefault(f => f.Field!.Name == "Контактный телефон");
        if (phoneField != null)
        {
            PhoneNumber = phoneField.Value;
        }
        var emailField = userInfo.Applications
            .SelectMany(app => app.FieldVals)
            .FirstOrDefault(f => f.Field!.Name == "Электронная почта");
        if (emailField != null)
        {
            Email = emailField.Value;
        }
    }
    
    public Guid Id { get; set; }
    public string? FullName { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Email { get; set; }
    public bool ReviewStatus { get; set; } = false;
}