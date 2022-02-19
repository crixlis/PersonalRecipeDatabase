public static class DatabaseInitializer {
    public static async Task Create()
    {
        using(var context = new RecipeDatabaseContext()){
            if(context == null){
                throw new SystemException(" initializing database.");
            }
            await context.Database.EnsureCreatedAsync();
            CreateSingleTestRecipe(context);
            await context.SaveChangesAsync();
        }
    }

    private static void CreateSingleTestRecipe(RecipeDatabaseContext context){
            var testRecipeName = "TestRecipe";
            var testRecipes = context.Recipes?.Where(x => x.Name == testRecipeName);
            if(testRecipes != null && testRecipes.Any()){
                context.Recipes?.RemoveRange(testRecipes);
            }
            
            var exampleRecipe = new Recipe{
                Name = testRecipeName,
                CreationTimeInMinutes = 15,
                //    Course = CourseEnum.Dinner,
                //    Ingredients = new List<string>{
                //        "zucchini","paprika", "pasta", "cheese"
                //    },
                //    Categories = new List<CategoryEnum>{
                //        CategoryEnum.Easy
                //    },
                //    CreationSteps = new List<string>{
                //        "This is the explanation for this recipe."
                //    },
                Rating = 4.5f,

            };
            context.Add(exampleRecipe);
    }
}