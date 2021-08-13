using Microsoft.AspNetCore.Mvc;
using TesteSoftplan.Data;

namespace TesteSoftplan.Services
{
    public interface IJurosService
    {
        string calculoJ([FromBody] Juros juros);
        decimal mostrarJ();
        string retornarUrl(string urlGithub);
    }
}