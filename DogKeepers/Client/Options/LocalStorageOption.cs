namespace DogKeepers.Client.Options
{
    public class LocalStorageOption
    {
        public string Token { get; set; }
        public string Expiration { get; set; }
        public int MinutesLeftToRefresh { get; set; }
    }
}