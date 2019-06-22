using CQRSInPractice.Application.Departamentos.Secretaria.Alunos.Commands;
using CQRSInPractice.Application.Departamentos.Secretaria.Alunos.Queries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CQRSInPractice.Web.SPA.Controllers
{
    public class StudentController : BaseController
    {
        [HttpGet("ObterAlunoPorNome")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<AlunoViewModel>> GetAlunoPorNome()
        {
            var query = new ObterAlunoPorNomeQuery()
            {
                Nome = "John Snow"
            };
            return Ok(await Mediator.Send(query));
        }

        [HttpGet("CadastrarNovoAluno")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> CadastrarNovoAluno()
        {
            var command = new RegistrarNovoAlunoCommand()
            {
                Nome = "John Snow",
                Idade = 30,
                Endereco = "North"
            };

            await Mediator.Send(command);
            return NoContent();
        }
    }
}