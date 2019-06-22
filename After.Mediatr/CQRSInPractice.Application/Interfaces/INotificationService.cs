using CQRSInPractice.Application.Notifications.Models;
using System.Threading.Tasks;

namespace CQRSInPractice.Application.Interfaces
{
    public interface INotificationService
    {
        Task SendAsync(Message message);
    }
}
