using CQRSInPractice.Application.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSInPractice.Application.Departamentos.Secretaria.Alunos.Commands
{
    public class RegistrarNovoAlunoCommandHandler : IRequestHandler<RegistrarNovoAlunoCommand, bool>
    {
        private readonly ICqrsDbContext _context;

        public RegistrarNovoAlunoCommandHandler(ICqrsDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(RegistrarNovoAlunoCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_context.RegistrarNovoAluno(request));
        }
    }
}
