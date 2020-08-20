namespace HomeCooking.api.Models.DTOs
{
    public struct RecipeDto
    {
        public int Id { get; }
        public string Name { get; }
        
        public RecipeDto(int id, string name)
        {
            Id = id;
            Name = name;
        }        
    }
}