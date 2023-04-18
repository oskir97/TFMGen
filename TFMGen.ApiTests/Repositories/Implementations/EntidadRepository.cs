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
    public class EntidadRepository : BaseRepository, IEntidadRepository
    {
        public ActionResult Asignarimagen(int p_oid, string p_imagen)
        {
            var result = Post<string,ActionResult>(API_URIs.entidadURI + "/Asignarimagen?p_oid="+ p_oid + "&p_imagen="+ p_imagen, "");
            return result.data != null ? result.data : null;
        }

        public ActionResult Configurar(int p_oid, string p_config)
        {
            var result = Post<string, ActionResult>(API_URIs.entidadURI + "/Configurar?p_oid="+ p_oid + "&p_config="+ p_config, "");
            return result.data != null ? result.data : null;
        }

        public ActionResult Darsebaja(int p_oid, DateTime? p_baja)
        {
            var result = Post<string, ActionResult>(API_URIs.entidadURI + "/Darsebaja?p_oid=" + p_oid + "&p_baja=" + p_baja, "");
            return result.data != null ? result.data : null;
        }

        public ActionResult<EntidadDTOA> Editar(int idEntidad, EntidadDTO dto)
        {
            var result = Put<EntidadDTO, ActionResult<EntidadDTOA>>(API_URIs.entidadURI + "/Editar?idEntidad=" + idEntidad, dto);
            return result.data != null ? result.data : null;
        }

        public ActionResult<List<EntidadDTOA>> Listar()
        {
            var result = Get<List<EntidadDTOA>>(API_URIs.entidadURI + "/Listar");
            return result.data != null ? result.data : null;
        }

        public ActionResult<EntidadDTOA> Obtener(int idEntidad)
        {
            var result = Get<EntidadDTOA>(API_URIs.entidadURI + "/" + idEntidad);
            return result.data != null ? result.data : null;
        }
    }
}
