using ETicaretApı.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApı.Application.Cqrs.Commands.AppUser.FacebookLogin
{
    public class FacebookLoginCommandResponse
    {
        public Token Token { get; set; }
    }
}