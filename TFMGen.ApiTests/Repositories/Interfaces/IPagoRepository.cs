using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFM_REST.DTO;
using TFM_REST.DTOA;

namespace TFMGen.ApiTests.Repositories.Interfaces
{
    public interface IPagoRepository
    {
        public ActionResult<PagoDTOA> Obtener(int idPago);
        public ActionResult<System.Collections.Generic.List<PagoDTOA>> Listar(int p_idreserva);
        public ActionResult<PagoDTOA> Crear(PagoDTO dto);

    }
}
