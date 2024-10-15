using ServerApp.Data.Entities;

namespace ServerApp.Data.Models.InspectionModel;

public class ApplicationStatusInspectionModel
{
    private readonly ApplicationStatus applicationStatus;
    
    public ApplicationStatusInspectionModel() { }

    public ApplicationStatusInspectionModel(ApplicationStatus applicationStatus)
    {
        this.applicationStatus = applicationStatus;
    }

    public Guid Id => applicationStatus.Id;
    public string Name => applicationStatus.Status;
}