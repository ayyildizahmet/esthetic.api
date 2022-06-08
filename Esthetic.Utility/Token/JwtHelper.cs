using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Esthetic.Domain;
using Esthetic.Model;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;


namespace Esthetic.Utility.Token
{
    public class JwtHelper : ITokenHelper
    {
        private IConfiguration Configuration { get; }  // appsetting dosyasından okumak için
        private TokenOptionsModel TokenOptions { get; }
        private readonly DateTime _accessTokenExpiration;
        public JwtHelper(IConfiguration configuration)
        {
            Configuration = configuration;
            TokenOptions = SetTokenOptions(); // appsetting den okuduk nesneye cevirdik
            _accessTokenExpiration = DateTime.Now.AddMinutes(TokenOptions.AccessTokenExpiration);
        }

        public AccessTokenModel CreateToken(UserLoginResponseModel user, List<OperationClaim> operationClaims)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(TokenOptions.SecurityKey));
            var signingCredential = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);
            var jwt = new JwtSecurityToken(
                issuer: TokenOptions.Issuer,
                audience: TokenOptions.Audience,
                expires: _accessTokenExpiration,
                notBefore: DateTime.Now,
                claims: SetClaims(user, operationClaims),
                signingCredentials: signingCredential
                );
            var token = new JwtSecurityTokenHandler().WriteToken(jwt);
            return new AccessTokenModel
            {
                Token = token,
                Expiration = _accessTokenExpiration
            };
        }

        private static IEnumerable<Claim> SetClaims(UserLoginResponseModel user, List<OperationClaim> operationClaims)
        {
            var claims = new List<Claim>();
            if (!string.IsNullOrEmpty(user.Email))
                claims.Add(new Claim(JwtRegisteredClaimNames.Email, user.Email));
            if (user.Id != default(int))
                claims.Add(new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()));
            if (!string.IsNullOrEmpty(user.FirstName) && !string.IsNullOrEmpty(user.LastName))
                claims.Add(new Claim(ClaimTypes.Name, $"{user.FirstName} {user.LastName}"));
            //operationClaims.Select(x => x.Name).ToList().ForEach(role => claims.Add(new Claim(ClaimTypes.Role, role)));
            return claims;
        }

        private TokenOptionsModel SetTokenOptions()
        {
            var tokenOptions = new TokenOptionsModel();
            var sectionItems = Configuration.GetSection("TokenOptions").GetChildren().ToList();
            tokenOptions.Issuer = sectionItems.FirstOrDefault(x => x.Key == "Issuer")?.Value;
            tokenOptions.Audience = sectionItems.FirstOrDefault(x => x.Key == "Audience")?.Value;
            tokenOptions.AccessTokenExpiration = Convert.ToInt32(sectionItems.FirstOrDefault(x => x.Key == "AccesTokenExpiration")?.Value);
            tokenOptions.SecurityKey = sectionItems.FirstOrDefault(x => x.Key == "SecurityKey")?.Value;
            return tokenOptions;
        }

     
    }
}
