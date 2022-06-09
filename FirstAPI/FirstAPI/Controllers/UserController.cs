using FirstAPI.Models;
using FirstAPI.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("myCors")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login(UserDTO user)
        {
            var result = await _userService.Login(user);
            if (result != null)
                return Ok(result);
            MesageDTO mesageDTO = new MesageDTO();
            mesageDTO.Title = "Login Error";
            mesageDTO.Description = "Invalid username or password";
            return BadRequest(mesageDTO);
        }
        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Post(UserDTO user)
        {
            var result = await _userService.Register(user);
            if (result != null)
                return Created("User Registered",result);
            MesageDTO mesageDTO = new MesageDTO();
            mesageDTO.Title = "Login Error";
            mesageDTO.Description = "Unable to register user";
            return BadRequest(mesageDTO);
        }
    }
}
