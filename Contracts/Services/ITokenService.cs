using Entities.Models;
using Microsoft.AspNetCore.Http;

namespace Contracts.Services
{
    public interface ITokenService
    {
        Token CreateStaticToken();
        bool Authenticate(HttpContext context);
    }
}