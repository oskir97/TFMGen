using Microsoft.AspNetCore.Mvc;
using TFMGen.ApiTests.Models;
using TFMGen.ApiTests.Models.DTO;
using TFMGen.ApiTests.Repositories.Interfaces;
using TFMGen.ApiTests.Services;

namespace TFMGen.ApiTests.Repositories.Implementations
{
    public class UsuarioRepository : BaseRepository, IUsuarioRepository
    {
        public ResponseModel<ActionResult<string>> Login(UsuarioDTO dto)
        {
            var result = Post<UsuarioDTO, ActionResult<string>> (API_URIs.usuarioURI + "/Login", dto);

            return result;
        }
    }
}
