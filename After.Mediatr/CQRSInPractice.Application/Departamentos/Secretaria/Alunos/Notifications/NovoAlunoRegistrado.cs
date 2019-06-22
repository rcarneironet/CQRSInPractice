using System.Threading;
using System.Threading.Tasks;
using CQRSInPractice.Application.Interfaces;
using CQRSInPractice.Application.Notifications.Models;
using MediatR;

namespace CQRSInPractice.Application.Departamentos.Secretaria.Alunos.Notifications
{
    public class NovoAlunoRegistrado : INotification
    {
        public int IdAluno { get; set; }

        public class NovoAlunoRegistradoHandler : INotificationHandler<NovoAlunoRegistrado>
        {
            private readonly INotificationService _notification;

            public NovoAlunoRegistradoHandler(INotificationService notification)
            {
                _notification = notification;
            }

            public async Task Handle(NovoAlunoRegistrado notification, CancellationToken cancellationToken)
            {
                //implementar a mensagem aqui
                await _notification.SendAsync(new Message());
            }
        }

    }
}
