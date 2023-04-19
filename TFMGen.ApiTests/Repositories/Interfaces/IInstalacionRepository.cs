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
    public interface IInstalacionRepository
    {
        public ActionResult<InstalacionDTOA> Obtener(int idInstalacion);
        public ActionResult<System.Collections.Generic.List<InstalacionDTOA>> Listar(int p_identidad);
        public ActionResult<InstalacionDTOA> Crear( InstalacionDTO dto);
        public ActionResult<InstalacionDTOA> Editar(int idInstalacion, InstalacionDTO dto);
        public ActionResult Eliminar(int p_instalacion_oid);
        public ActionResult Asignarpista(int p_instalacion_oid, System.Collections.Generic.IList<int> p_pistas_oids);
        public ActionResult Asignarimagen(int p_oid, string p_imagen);
    }
}
