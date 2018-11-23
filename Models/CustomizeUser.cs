using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_IdentityRole.Models
{
    public class CustomizeUser
{
        [PersonalData]
        public string username { get; set; }
}
}
