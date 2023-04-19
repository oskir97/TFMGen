using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFM_REST.DTO;
using TFMGen.ApiTests.Repositories.Interfaces;
using TFMGen.ApiTests.Services;

namespace TFMGen.ApiTests.Repositories.Implementations
{
    public class UsuarioRepository : BaseRepository, IUsuarioRepository
    {
        public ActionResult<string> Login(UsuarioDTO dto)
        {
            var result = Post<UsuarioDTO, ActionResult>(API_URIs.usuarioURI + "/Login", dto);
            return result.data != null ? result.data : null;
        }
    }
}
