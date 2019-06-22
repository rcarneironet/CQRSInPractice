using CQRSInPractice.Application.Interfaces;
using CQRSInPractice.Infrastructure.Notifications;
using Microsoft.Extensions.DependencyInjection;

namespace CQRSInPractice.Infrastructure.IoC
{
    public static class Bootstrapper
    {
        public static void RegisterRepositoryServices(this IServiceCollection services)
        {
            services.AddTransient<INotificationService, NotificationService>();
        }
    }
}
