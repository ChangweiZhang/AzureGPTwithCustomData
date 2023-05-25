using Azure.Search.Documents.Models;
using Backend.Model;
using Backend.Service;
using Microsoft.AspNetCore.Mvc;
using System.Buffers.Text;
using System.ServiceModel.Security;
using System.Text;
using WebApi.Controllers;

namespace Backend.Controllers
{
    [ApiController]
    [Route("api/login")]
    public class LoginController : ControllerBase
    {

        private readonly ILogger<FilesController> _logger;
        private readonly string? userName;
        private readonly string? password;

        public LoginController(
            ILogger<FilesController> logger,
            IConfiguration configuration)
        {
            _logger = logger;
            userName = configuration["Admin:UserName"];
            password = configuration["Admin:Password"];
        }


        [HttpPost]
        public async Task<ActionResult<object>> PostAync([FromBody] LoginViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var authorization = vm.Authorization;
            byte[] decodedBytes = Convert.FromBase64String(authorization);
            string decodedText = Encoding.UTF8.GetString(decodedBytes);
            var credentials = decodedText.Split(":");
            if (credentials?.Length == 2)
            {
                if (userName?.Equals(credentials?[0]) == true
                    && password?.Equals(credentials?[1])==true)
                {
                    return Ok(new
                    {
                        Message="login successfully"
                    });
                }
            }
            return Unauthorized();
        }
        
    }
    public class LoginViewModel
    {
        public string Authorization { get; set; }
    }
}
