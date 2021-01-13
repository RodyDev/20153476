using DogKeepers.Shared.Metadata;

namespace DogKeepers.Shared.ApiResponses
{
    public class ApiResponse<T>
    {
        public T Data { get; set; }
        public PaginationMetadata Pagination { get; set; }
        public ErrorResponse[] Errors { get; set; }

        public ApiResponse()
        {}

        public ApiResponse(T data, PaginationMetadata pagination)
        {
            Data = data;
            Pagination = pagination;
        }
    }
}