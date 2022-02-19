using System.Linq;
using Contracts.Services;
using Entities.Models;
using Microsoft.AspNetCore.Http;

namespace Services
{
    public class TokenService : ITokenService
    {
        public Token GetTokenFromHeader(HttpContext context)
        {
            var tokenString = context.Request.Headers
                .Where(x =>
                    x.Key.Equals("Authorization"))
                .Select(x => x.Value)
                .FirstOrDefault().ToString().Split(' ');
            return new Token(tokenString[1]);
        }
        
        public Token CreateStaticToken() => new (Generics.Settings.Token.BearerToken);

        public bool Authenticate(HttpContext context) =>
            GetTokenFromHeader(context).JwtToken.Equals(Generics.Settings.Token.BearerToken);
    }
}