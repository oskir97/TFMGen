using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFM_REST.DTO;
using TFM_REST.DTOA;
using TFMGen.ApiTests.Repositories.Interfaces;
using TFMGen.ApiTests.Services;

namespace TFMGen.ApiTests.Repositories.Implementations
{
    public class PagoRepository : BaseRepository, IPagoRepository
    {
        public ActionResult<PagoDTOA> Crear(PagoDTO dto)
        {
            var result = Post<PagoDTO, ActionResult<PagoDTOA>>(API_URIs.pagoURI + "/Crear", dto);
            return result.data != null ? result.data : null;
        }

        public ActionResult<List<PagoDTOA>> Listar(int p_idreserva)
        {
            var result = Get<List<PagoDTOA>>(API_URIs.pagoURI + "/Listar?p_idreserva=" + p_idreserva);
            return result.data != null ? result.data : null;
        }

        public ActionResult<PagoDTOA> Obtener(int idPago)
        {
            var result = Get<PagoDTOA>(API_URIs.pagoURI + "/" + idPago);
            return result.data != null ? result.data : null;
        }
    }
}
