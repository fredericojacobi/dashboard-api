using System;

namespace Entities.Models
{
    public class Token
    {
        public string JwtToken { get; set; }
        
        public Token(string token) => JwtToken = token;
    }
}