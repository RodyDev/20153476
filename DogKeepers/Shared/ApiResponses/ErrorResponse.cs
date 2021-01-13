namespace DogKeepers.Shared.ApiResponses
{
    public class ErrorResponse
    {
        public int Status { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
    }
}