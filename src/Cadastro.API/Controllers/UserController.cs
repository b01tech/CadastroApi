using Cadastro.API.DTOs.Requests;
using Cadastro.Application.UseCase.User;
using Cadastro.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;


namespace Cadastro.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult Create(UserCreateRequestJson request)
        {
            var usecase = new UserCreateUseCase();
            var response = usecase.Execute(request);
            return Created(string.Empty,response);
        }
    }
}
