using System.Threading;
using System.Threading.Tasks;
using CQRSInPractice.Application.Interfaces;
using MediatR;

namespace CQRSInPractice.Application.Departamentos.Secretaria.Alunos.Queries
{
    public class ObterAlunoPorNomeQueryHandler : IRequestHandler<ObterAlunoPorNomeQuery, AlunoViewModel>
    {
        private readonly ICqrsDbContext _context;
        public ObterAlunoPorNomeQueryHandler(ICqrsDbContext context)
        {
            _context = context;
        }

        public async Task<AlunoViewModel> Handle(ObterAlunoPorNomeQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_context.ObterAlunoPorNome(request));
        }
    }
}
