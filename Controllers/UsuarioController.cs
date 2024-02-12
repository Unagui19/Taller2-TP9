using Microsoft.AspNetCore.Mvc;
using Entidades.Models;
using Entidades.Repositorios;
namespace Taller2_TP9.Controllers;

[ApiController]
[Route("[controller]")]
public class UsuarioController : ControllerBase
{
    private UsuarioRepository RepoUsuario;

    private readonly ILogger<UsuarioController> _logger;

    public UsuarioController(ILogger<UsuarioController> logger)
    {
        RepoUsuario = new UsuarioRepository();
        _logger = logger;
    }

    [HttpGet ("api/usuario", Name = "Listado de usuarios")]
    public ActionResult<IEnumerable<Usuario>> ListarUsuarios(){
        return RepoUsuario.ListarUsuarios();
    }
}
