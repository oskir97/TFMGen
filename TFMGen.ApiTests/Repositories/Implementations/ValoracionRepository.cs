using Microsoft.AspNetCore.Mvc;
using TFMGen.ApiTests.Models;
using TFMGen.ApiTests.Models.DTO;
using TFMGen.ApiTests.Models.DTOA;
using TFMGen.ApiTests.Repositories.Interfaces;
using TFMGen.ApiTests.Services;

namespace TFMGen.ApiTests.Repositories.Implementations
{
    public class ValoracionRepository : BaseRepository, IValoracionRepository
    {
        public ResponseModel<ValoracionDTOA> Crear(ValoracionDTO dto)
        {
            var result = Post<ValoracionDTO, ValoracionDTOA>(API_URIs.valoracionURI + "/Crear", dto);
            return result;
        }

        public ResponseModel<ValoracionDTOA> Editar(int idValoracion, ValoracionDTO dto)
        {
            var result = Put<ValoracionDTO, ValoracionDTOA>(API_URIs.valoracionURI + "/Editar?idValoracion=" + idValoracion, dto);
            return result;
        }

        public ResponseModel<ActionResult> Eliminar(int p_valoracion_oid)
        {
            var result = Delete<ActionResult>(API_URIs.valoracionURI + "/Eliminar?p_valoracion_oid=" + p_valoracion_oid);
            return result;
        }

        public ResponseModel<List<ValoracionDTOA>> Listar(int p_idusuario)
        {
            var result = Get<List<ValoracionDTOA>>(API_URIs.valoracionURI + "/Listar?p_idusuario=" + p_idusuario);
            return result;
        }

        public ResponseModel<List<ValoracionDTOA>> Listarentidad(int p_identidad)
        {
            var result = Get<List<ValoracionDTOA>>(API_URIs.valoracionURI + "/Listarentidad?p_identidad=" + p_identidad);
            return result;
        }

        public ResponseModel<List<ValoracionDTOA>> Listarinstalacion(int p_idinstalacion)
        {
            var result = Get<List<ValoracionDTOA>> (API_URIs.valoracionURI + "/Listarinstalacion?p_idinstalacion=" + p_idinstalacion);
            return result;
        }

        public ResponseModel<List<ValoracionDTOA>> Listarpista(int p_idpista)
        {
            var result = Get<List<ValoracionDTOA>>(API_URIs.valoracionURI + "/Listarpista?p_idpista=" + p_idpista);
            return result;
        }

        public ResponseModel<List<ValoracionDTOA>> Listartecnico(int p_idusuario)
        {
            var result = Get<List<ValoracionDTOA>>(API_URIs.valoracionURI + "/Listartecnico?p_idusuario=" + p_idusuario);
            return result;
        }

        public ResponseModel<ValoracionDTOA> Obtener(int idValoracion)
        {
            var result = Get<ValoracionDTOA>(API_URIs.valoracionURI + "/" + idValoracion);
            return result;
        }

        public ResponseModel<List<ValoracionDTOA>> ObtenerValoracionesRealizadas(int idUsuarioRegistrado)
        {
            var result = Get<List<ValoracionDTOA>>(API_URIs.valoracionURI + "/ObtenerValoracionesRealizadas?idUsuarioRegistrado=" + idUsuarioRegistrado);
            return result;
        }

        public ResponseModel<ActionResult> Valorarentidad(int p_valoracion, int p_entidad)
        {
            var result = Post<string, ActionResult>(API_URIs.valoracionURI + "/Valorarentidad?p_valoracion=" + p_valoracion + "&p_entidad=" + p_entidad, "");
            return result;
        }

        public ResponseModel<ActionResult> Valorarinstalacion(int p_valoracion, int p_instalacion)
        {
            var result = Post<string, ActionResult>(API_URIs.valoracionURI + "/Valorarinstalacion?p_valoracion=" + p_valoracion + "&p_instalacion=" + p_instalacion, "");
            return result;
        }

        public ResponseModel<ActionResult> Valorarpista(int p_valoracion, int p_pista)
        {
            var result = Post<string, ActionResult>(API_URIs.valoracionURI + "/Valorarpista?p_valoracion=" + p_valoracion + "&p_pista=" + p_pista, "");
            return result;
        }

        public ResponseModel<ActionResult> Valorartecnico(int p_valoracion, int p_tecnico)
        {
            var result = Post<string, ActionResult>(API_URIs.valoracionURI + "/Valorartecnico?p_valoracion=" + p_valoracion + "&p_tecnico=" + p_tecnico, "");
            return result;
        }

        public ResponseModel<List<ValoracionDTOA>> Listartodas()
        {
            var result = Get<List<ValoracionDTOA>>(API_URIs.valoracionURI + "/Listartodas");
            return result;
        }
    }
}
