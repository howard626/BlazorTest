using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using BlazorTest.Models;
using BlazorTest.Server.Service;
using BlazorTestShared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace BlazorTest.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration configuration;
        private readonly IUserService _userService;

        public AuthController(IConfiguration configuration, IUserService userService)
        {
            this.configuration = configuration;
            _userService = userService;
        }

        [HttpPost("Login")]
        public ActionResult<UserToken> Login([FromBody] User userInfo)
        {
            User user = _userService.UserLogin(userInfo.Account, userInfo.Password);
            
            if (user != null)
            {
                return BuildToken(user);
            }

            return BadRequest("帳號或密碼錯誤");
        }

        [HttpPost("Register")]
        public ActionResult<string> Register([FromBody] RegisterModel register)
        {

            return _userService.Register(register);
        }

        /// <summary>
        /// 建立Token
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        private UserToken BuildToken(User userInfo)
        {
            //記在jwt payload中的聲明，可依專案需求自訂Claim
            var roles = userInfo.Role.Split(',');

            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, userInfo.Name ?? string.Empty)
            };

            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            //取得對稱式加密 JWT Signature 的金鑰
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["jwt:Key"]));
            var credential = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            //設定token有效期限
            DateTime expireTime = DateTime.Now.AddMinutes(30);

            //產生token
            JwtSecurityTokenHandler jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            JwtSecurityToken jwtSecurityToken = new JwtSecurityToken(
                issuer: null,
                audience: null,
                claims: claims,
                expires: expireTime,
                signingCredentials: credential
                );
            string jwtToken = jwtSecurityTokenHandler.WriteToken(jwtSecurityToken);

            //建立UserToken物件後回傳client
            UserToken userToken = new UserToken()
            {
                StatusCode = System.Net.HttpStatusCode.OK,
                token = jwtToken,
                ExpireTime = expireTime
            };

            return userToken;
        }
    }
}