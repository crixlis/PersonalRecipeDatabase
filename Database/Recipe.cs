namespace PersonalRecipeDatabase.Database;

public class Recipe
{
    // Primary key
    public int RecipeID { get; set; }
    public string Name { get; set; } = "";
    public float Rating { get; set; }
    public int CreationTimeInMinutes { get; set; }
    public CourseType Course {get; set;}
    public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
    // public List<string> CreationSteps { get; set; } = new List<string>();
    // public List<CategoryEnum> Categories { get; set; } = new List<CategoryEnum>();
}