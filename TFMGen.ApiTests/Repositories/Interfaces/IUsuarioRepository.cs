using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFM_REST.DTO;

namespace TFMGen.ApiTests.Repositories.Interfaces
{
    public interface IUsuarioRepository
    {
        public ActionResult<string> Login(UsuarioDTO dto);
    }
}
