using System;
using Generics.Entities;

namespace Entities.Models
{
    public class User : ModelBase
    { 
        public string UserName { get; set; }

        public User(string userName) => UserName = userName;
    }
}