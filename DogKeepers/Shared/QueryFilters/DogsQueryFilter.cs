using DogKeepers.Shared.CustomEntities;

namespace DogKeepers.Shared.QueryFilters
{
    public class DogsQueryFilter : Pagination
    {
        public int Random { get; set; } = 0;
        public int RaceId { get; set; }
        public int SizeId { get; set; }
        public string Name { get; set; }
    }
}