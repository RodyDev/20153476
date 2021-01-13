using System;
namespace DogKeepers.Server.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime DateBirth { get; set; }
        public string Phone { get; set; }

        public int AdoptationRating { get; set; }

        public DateTime RegistrationDate { get; set; }
    } 
}