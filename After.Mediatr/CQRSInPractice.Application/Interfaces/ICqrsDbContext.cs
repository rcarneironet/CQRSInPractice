using CQRSInPractice.Application.Departamentos.Secretaria.Alunos.Commands;
using CQRSInPractice.Application.Departamentos.Secretaria.Alunos.Queries;

namespace CQRSInPractice.Application.Interfaces
{
    public interface ICqrsDbContext
    {
        //bool RegistrarNovoAluno(RegistrarNovoAlunoCommand command);
        AlunoViewModel ObterAlunoPorNome(ObterAlunoPorNomeQuery query);
        bool RegistrarNovoAluno(RegistrarNovoAlunoCommand command);

    }
}
