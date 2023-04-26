using Microsoft.AspNetCore.Mvc;
using TFMGen.ApiTests.Models;
using TFMGen.ApiTests.Models.DTO;
using TFMGen.ApiTests.Models.DTOA;

namespace TFMGen.ApiTests.Repositories.Interfaces
{
    public interface IUsuarioRepository
    {
        public ResponseModel<ActionResult<string>> Login(UsuarioDTO dto);

        public ResponseModel<UsuarioDTOA> Crear(UsuarioDTO dto);
    }
}
