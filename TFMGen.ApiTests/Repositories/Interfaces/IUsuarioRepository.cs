using Microsoft.AspNetCore.Mvc;
using TFMGen.ApiTests.Models;
using TFMGen.ApiTests.Models.DTO;

namespace TFMGen.ApiTests.Repositories.Interfaces
{
    public interface IUsuarioRepository
    {
        public ResponseModel<ActionResult<string>> Login(UsuarioDTO dto);
    }
}
