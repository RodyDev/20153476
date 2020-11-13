using DogKeepers.Shared.CustomEntities;

namespace DogKeepers.Shared.QueryFilters
{
    public class DogsQueryFilter : Pagination
    {
        public int Random { get; set; } = 0;
    }
}