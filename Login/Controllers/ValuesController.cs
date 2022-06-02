using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Login.ModelEntities;
using LoginEntities;
using System.Linq;
using System.Threading.Tasks;
using Login_ManagerLayer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.Extensions.Configuration;
using System.IdentityModel.Tokens.Jwt;

namespace Login.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly Search _depocontext;
        private IConfiguration _config;
        public ValuesController(Search search, IConfiguration config)
        {
            _depocontext = search;
            _config = config;
        }
       

        // GET api/values/5
        [HttpGet("/api/values/{username}/{password}")]
        public IActionResult Login(string username, string password)
        {

            Class1 obj = new Class1();
            obj.Username = username;
            obj.Password = password;
            IActionResult response = Unauthorized();
            bool value=   _depocontext.Login(obj);
            if(value== true)
            {
                var tokenString = GenerateJSONWebToken(username);
                response = Ok(new { token = tokenString });
            }   
            else
            {
                response = Ok("User does not exist");
            }

            return response;
      
        }
        [HttpGet("/api/values/user/{username}/{password}")]
        public IActionResult User(string username, string password)
        {

            Class1 obj = new Class1();
            obj.Username = username;
            obj.Password = password;
            IActionResult response = Unauthorized();
            bool value = _depocontext.User(obj);
            if (value == true)
            {
                var tokenString = GenerateJSONWebToken(username);
                response = Ok(new { token = tokenString });
            }
            else
            {
                response = Ok("User does not exist");
            }

            return response;

        }
        [HttpGet("/api/values/register/{username}/{password}")]
        public void Register(string username, string password)
        {

            Class1 obj = new Class1();
            obj.Username = username;
            obj.Password = password;
           _depocontext.Register(username, password);

        }
        private string GenerateJSONWebToken(string username)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
              _config["Jwt:Issuer"],
              null,
              expires: DateTime.Now.AddMinutes(120),
              signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
