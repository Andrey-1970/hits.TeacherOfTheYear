using ServerApp.Data.Entities;

namespace ServerApp.Data.Models.EditModel;

public class CategoryModel
{
    public CategoryModel()
    {
        
    }
    public CategoryModel(Category category)
    {
        //ArgumentNullException.ThrowIfNull(category);
        Id = category.Id;
        Number = category.Number;
        Name = category.Name;
    }

    public Category ToEntity()
    {
        if (Number == null) throw new InvalidOperationException("Number cannot be null.");
        
        return new Category()
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