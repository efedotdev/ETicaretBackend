using ETicaretApı.Application.Abstractions.Token;
using ETicaretApı.Application.DTOs;
using ETicaretApı.Application.DTOs.Facebook;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ETicaretApı.Application.Abstractions.Services;
using ETicaretApı.Application.Cqrs.Commands.AppUser.FacebookLogin;

namespace ETicaretApı.Application.Cqrs.Commands.AppUser.FacebookLogin
{
    public class FacebookLoginCommandHandler : IRequestHandler<FacebookLoginCommandRequest, FacebookLoginCommandResponse>
    {
        readonly IAuthService _authService;

        public FacebookLoginCommandHandler(IAuthService authService)
        {
            _authService = authService;
        }

        public async Task<FacebookLoginCommandResponse> Handle(FacebookLoginCommandRequest request,
            CancellationToken cancellationToken)
        {
            var token = await _authService.FacebookLoginAsync(request.AuthToken, 900);
            return new()
            {
                Token = token
            };
        }
    }
}