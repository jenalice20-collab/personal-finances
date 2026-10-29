namespace PersonalFinances.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Linq;

    using Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Repositories.DatabaseContext>
    {
        private readonly bool _seedDatabase = true;

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Repositories.DatabaseContext context)
        {
            if (_seedDatabase)
            {
                // Add Transfer category and subcategory
                AddCategoryIfMissing(context, "Transfer", "C", "Other");
                AddCategoryIfMissing(context, "Transfer", "D", "Other");

                // Add Payment category and Credit card subcategory
                AddCategoryIfMissing(context, "Payments", "D", "Credit card");

                context.SaveChanges();
            }
        }

        /// <summary>
        /// Add a default category with one subcategory, only if the category does not exist yet,
        /// so the Seed method can run on every Update-Database without creating duplicates
        /// </summary>
        private static void AddCategoryIfMissing (Repositories.DatabaseContext context, string name, string type, string subcategoryName)
        {
            if (context.Categories.Any(c => c.Name == name && c.Type == type))
                return;

            context.Subcategories.Add(new Subcategory
            {
                Name = subcategoryName,
                Category = new Category { Name = name, Type = type, Enabled = true },
                Enabled = true,
                CanEdit = false
            });
        }
    }
}
