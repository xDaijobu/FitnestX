namespace FitnestX.Models;

public class GoalModel
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Image { get; set; }

    public GoalModel(string title, string description, string image)
    {
        Title = title;
        Description = description;
        Image = image;
    }
}