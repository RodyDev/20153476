namespace DogKeepers.Server.Entities
{
    public class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Conditions { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public byte[] PictureFile { get; set; }
        public int RaceId { get; set; }
        public int SizeId { get; set; }
        public int Age { get; set; }
        public Race Race { get; set; }
        public Size Size { get; set; }
    }
}