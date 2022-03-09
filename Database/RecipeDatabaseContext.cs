using Microsoft.EntityFrameworkCore;

namespace PersonalRecipeDatabase.Database;

public class RecipeDatabaseContext: DbContext{
    public string DatabaseLocation =>  $"{Environment.CurrentDirectory}/Database/Recipe.db";
    public DbSet<Recipe>? Recipes { get; set; }

    // Creates the Recipe database
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DatabaseLocation}");

    protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<Recipe>()
                .ToTable("Recipes");

            modelBuilder.Entity<Recipe>()
                .Property(s => s.Course)
                .HasConversion<string>();

            modelBuilder.Entity<Recipe>()
                .HasMany(x => x.Ingredients);

        base.OnModelCreating(modelBuilder);
    }
}