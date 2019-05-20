using Microsoft.Extensions.Logging;

namespace CharacterSheet.Services
{
    public interface IMailService
    {
        void SendMessage(string to, string subject, string body);
    }
}