using MediatR;

namespace CQRSInPractice.Application.Departamentos.Secretaria.Alunos.Queries
{
    public class ObterAlunoPorNomeQuery : IRequest<AlunoViewModel>
    {
        public string Nome { get; set; }
    }
}
