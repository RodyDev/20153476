using DogKeepers.Server.Entities;

namespace DogKeepers.Server.Interfaces.Utils
{
    public interface IJwtUtil
    {
        Jwt Generate(dynamic data);
    }
}