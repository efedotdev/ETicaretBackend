using ETicaretApı.Application.Abstractions.Services;
using ETicaretApı.Application.DTOs.User;
using ETicaretApı.Application.Exceptions;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace ETicaretApı.Application.Cqrs.Commands.AppUser.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommandRequest, CreateUserCommandResponse>
    {
        readonly IUserService _userService;

        public CreateUserCommandHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<CreateUserCommandResponse> Handle(CreateUserCommandRequest request,
            CancellationToken cancellationToken)
        {
            CreateUserResponse response = await _userService.CreateAsync(new()
            {
                Email = request.Email,
                Password = request.Password,
                NameSurname =  request.NameSurname,
                PasswordConfirm =  request.PasswordConfirm,
                Username =  request.Username
            });

            return new ()
            {
                Succeeded = response.Succeeded,
                Message = response.Message
            };

            //throw new UserCreateFailedException();
        }
    }
}