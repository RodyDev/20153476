using System.Threading.Tasks;
using DogKeepers.Server.Interfaces.Services;
using DogKeepers.Shared.ApiResponses;
using DogKeepers.Shared.DTOs;
using DogKeepers.Shared.QueryFiltersame;
using Microsoft.AspNetCore.Mvc;

namespace DogKeepers.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        

        private readonly IAuthService authService;

        public AuthController(IAuthService authService)
        {
            this.authService = authService;
        }

        [HttpPost]
        public async Task<IActionResult> Post(SignInQueryFilter model)
        {
            var response = await authService.Authenticate(model);
            var apiResponse = new ApiResponse<JwtDto>(
                new JwtDto(){
                    Token = response.Token,
                    ExpirationDate = response.ExpirationDate,
                    User = new UserDto(){
                        Id = response.User.Id,
                        Email = response.User.Email,
                        Name = response.User.Name
                    }
                    },
                    null
            );
            return Ok(apiResponse);
        }
    }
}