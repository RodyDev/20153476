using System.Threading.Tasks;
using DogKeepers.Server.Entities;
using DogKeepers.Server.Exceptions;
using DogKeepers.Server.Interfaces.Repositories;
using DogKeepers.Server.Interfaces.Services;
using DogKeepers.Server.Interfaces.Utils;

using DogKeepers.Shared.QueryFiltersame;

namespace DogKeepers.Server.Services
{
    public class AuthService : IAuthService
    {


        private readonly IUserRepository userRepository;
        private readonly IJwtUtil jwtUtil;
        public AuthService(IUserRepository userRepository, IJwtUtil jwtUtil)
        {
            this.jwtUtil = jwtUtil;
            this.userRepository = userRepository;
        }

        public async Task<Jwt> Authenticate(SignInQueryFilter user)
        {
            var userData = await userRepository.GetByEmailPassword(user);

            if (userData == null)
                throw new BusinessException("Los datos de acceso son incorrectos");

            var data = new{
                Id = userData.Id,
                Name = userData.Name
            };
            var token = jwtUtil.Generate(data);

            if (token == null)
                throw new BusinessException("No se pudo iniciar sesión, intente nuevamente.");
            
            token.User = userData;
            
            return token;
        }
    }
}