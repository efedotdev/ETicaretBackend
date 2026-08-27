namespace ETicaretApı.Application.Exceptions;

public class AuthenticationErrorExeptions : Exception
{
    public AuthenticationErrorExeptions() : base("Kimlik doğrulama hatası!")
    {
    }

    public AuthenticationErrorExeptions(string? message) : base(message)
    {
    }

    public AuthenticationErrorExeptions(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}