using Dg_payroll.AppModel;
using Dg_payroll.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Dg_payroll.Data;
using Microsoft.AspNetCore.Authorization;

namespace Dg_payroll.Controllers
{

    [ApiController]
    public class LoginController : ControllerBase
    {
        dg_hrpayrollContext _context = new dg_hrpayrollContext();

        IConfiguration _configuration;

        public LoginController(IConfiguration configuration)
        {
            _configuration = configuration;
        }



        [HttpPost]
        [Route("PostLoginDetails")]
        public async Task<IActionResult> PostLoginDetails(UserModel _userData)
        {
            if (_userData != null)
            {
                var resultLoginCheck = _context.TblUsers
                    //.Where(e => e.EmailId == _userData.EmailId && e.Password == _userData.Password)
                    .Where(e => e.FullName == _userData.FullName && e.Password == _userData.Password)
                    .FirstOrDefault();
                if (resultLoginCheck == null)
                {
                    return BadRequest("Invalid Credentials");
                }
                else
                {
                    _userData.UserMessage = "Login Success";

                    var claims = new[] {
                        new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt:Subject"]),
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                        new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                        new Claim("UserId", _userData.ID.ToString()),
                        new Claim("DisplayName", _userData.FullName),
                        new Claim("UserName", _userData.FullName),
                        new Claim("Email", _userData.EmailId)
                    };


                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
                    var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                    var token = new JwtSecurityToken(
                        _configuration["Jwt:Issuer"],
                        _configuration["Jwt:Audience"],
                        claims,
                        expires: DateTime.UtcNow.AddMinutes(1000000),
                        signingCredentials: signIn);


                    _userData.AccessToken = new JwtSecurityTokenHandler().WriteToken(token);

                    var accessToken = _userData.AccessToken;

                    return Ok(new { accessToken = accessToken });
                    //string input = string.Empty;
                }
            }
            else
            {
                return BadRequest("No Data Posted");
            }
        }



    }
}
