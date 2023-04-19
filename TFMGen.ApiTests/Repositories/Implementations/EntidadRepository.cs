using Microsoft.AspNetCore.Mvc;
using TFMGen.ApiTests.Models;
using TFMGen.ApiTests.Models.DTO;
using TFMGen.ApiTests.Models.DTOA;
using TFMGen.ApiTests.Repositories.Interfaces;
using TFMGen.ApiTests.Services;

namespace TFMGen.ApiTests.Repositories.Implementations
{
    public class EntidadRepository : BaseRepository, IEntidadRepository
    {
        public ResponseModel<ActionResult> Asignarimagen(int p_oid, string p_imagen)
        {
            var result = Post<string,ActionResult>(API_URIs.entidadURI + "/Asignarimagen?p_oid="+ p_oid + "&p_imagen="+ p_imagen, "");

            return result;
        }

        public ResponseModel<ActionResult> Configurar(int p_oid, string p_config)
        {
            var result = Post<string, ActionResult>(API_URIs.entidadURI + "/Configurar?p_oid="+ p_oid + "&p_config="+ p_config, "");

            return result;
        }

        public ResponseModel<ActionResult> Darsebaja(int p_oid, DateTime? p_baja)
        {
            var result = Post<string, ActionResult>(API_URIs.entidadURI + "/Darsebaja?p_oid=" + p_oid + "&p_baja=" + p_baja, "");

            return result;
        }

        public ResponseModel<EntidadDTOA> Editar(int idEntidad, EntidadDTO dto)
        {
            var result = Put<EntidadDTO, EntidadDTOA>(API_URIs.entidadURI + "/Editar?idEntidad=" + idEntidad, dto);

            return result;
        }

        public ResponseModel<List<EntidadDTOA>> Listar()
        {
            var result = Get <List<EntidadDTOA>>(API_URIs.entidadURI + "/Listar");

            return result;
        }

        public ResponseModel<EntidadDTOA> Obtener(int idEntidad)
        {
            var result = Get <EntidadDTOA>(API_URIs.entidadURI + "/" + idEntidad);

            return result;
        }
    }
}
