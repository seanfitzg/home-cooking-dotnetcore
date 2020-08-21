using System.Collections.Generic;

namespace HomeCooking.Domain.Entities
{
    public class Recipe
    {
        public Recipe()
        {
            Ingredients = new List<Ingredient>();
        }
        public string Name { get;  set; }
        public string Method { get;  set; }
        public IEnumerable<Ingredient> Ingredients { get;  set; }
        public int Id { get; set; }
    }
}