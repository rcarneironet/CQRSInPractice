using CQRSInPractice.Application.Interfaces;
using CQRSInPractice.Application.Notifications.Models;
using System.Threading.Tasks;

namespace CQRSInPractice.Infrastructure.Notifications
{
    public class NotificationService : INotificationService
    {
        public Task SendAsync(Message message)
        {
            return Task.CompletedTask;
        }
    }
}
