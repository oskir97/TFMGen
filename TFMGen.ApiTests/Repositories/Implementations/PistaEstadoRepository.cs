﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFM_REST.DTOA;
using TFMGen.ApiTests.Repositories.Interfaces;
using TFMGen.ApiTests.Services;

namespace TFMGen.ApiTests.Repositories.Implementations
{
    public class PistaEstadoRepository : BaseRepository, IPistaEstadoRepository
    {
        public ActionResult<List<PistaEstadoDTOA>> Listar()
        {
            var result = Get<List<PistaEstadoDTOA>>(API_URIs.pistaEstadoURI + "/Listar");
            return result.data != null ? result.data : null;
        }
    }
}
