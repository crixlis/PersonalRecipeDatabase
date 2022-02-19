using Microsoft.EntityFrameworkCore;

public class RecipeDatabaseContext: DbContext{
    public string DatabaseLocation =>  $"{Environment.CurrentDirectory}/Database/Recipe.db";
    public DbSet<Recipe>? Recipes { get; set; }

    // Creates the Recipe database
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DatabaseLocation}");
}