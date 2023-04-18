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
    public interface IEntidadRepository
    {
        public ActionResult<List<EntidadDTOA>> Listar();
        public ActionResult<EntidadDTOA> Obtener(int idEntidad);
        public ActionResult<EntidadDTOA> Editar(int idEntidad, EntidadDTO dto);
        public ActionResult Asignarimagen(int p_oid, string p_imagen);
        public ActionResult Darsebaja(int p_oid, Nullable<DateTime> p_baja);
        public ActionResult Configurar(int p_oid, string p_config);
    }
}
