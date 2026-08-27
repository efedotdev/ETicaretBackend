namespace ETicaretApı.Application.Abstractions.Services;

public interface IMailService
{
    Task SendMailAsync(string to, string subject, string body, bool isBodyHtml = true);
    Task SendMailAsync(string[] tos, string subject, string body, bool isBodyHtml = true);
    Task SendCompletedOrderMailAsync(string to, string orderCode, DateTime orderDate, string userName);
    Task SendPasswordResetMailAsync(string to, string userId, string resetToken);
}