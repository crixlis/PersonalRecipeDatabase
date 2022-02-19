public class Recipe
{
    // Primary key
    public int RecipeID { get; set; }
    public string Name { get; set; } = "";
    public float Rating { get; set; }
    public int CreationTimeInMinutes { get; set; }
    // public List<string> Ingredients { get; set; } = new List<string>();
    // public List<string> CreationSteps { get; set; } = new List<string>();
    // public CourseEnum Course { get; set; }
    // public List<CategoryEnum> Categories { get; set; } = new List<CategoryEnum>();
}