using GerenciadorDeTarefasCommunication.Response;

namespace GerenciadorDeTarefasApplication.UseCase.Register
{
    public class RegisterGerenciadorUserCase
    {
        public ResponseRegisterGerenciadorJson Executar(ResponseGerenciadorJson request)
        {
            return new ResponseRegisterGerenciadorJson
            {
                Id = 1,
                Name = request.Name,
            };
        }
    }
}
