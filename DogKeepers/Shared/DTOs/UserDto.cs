using System;

namespace DogKeepers.Shared.DTOs
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DateBirth { get; set; }
        public string Phone { get; set; }

        public int AdoptationRating { get; set; }

        public DateTime RegistrationDate { get; set; }
    }
}