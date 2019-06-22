using MediatR;

namespace CQRSInPractice.Application.Departamentos.Secretaria.Alunos.Commands
{
    public class RegistrarNovoAlunoCommand : IRequest<bool>
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Endereco { get; set; }
    }
}
