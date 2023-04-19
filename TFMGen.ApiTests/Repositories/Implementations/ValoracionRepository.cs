using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TFM_REST.DTO;
using TFM_REST.DTOA;
using TFMGen.ApiTests.Repositories.Interfaces;
using TFMGen.ApiTests.Services;

namespace TFMGen.ApiTests.Repositories.Implementations
{
    public class ValoracionRepository : BaseRepository, IValoracionRepository
    {
        public ActionResult<ValoracionDTOA> Crear(ValoracionDTO dto)
        {
            var result = Post<ValoracionDTO, ActionResult>(API_URIs.valoracionURI + "/Crear", dto);
            return result.data != null ? result.data : null;
        }

        public ActionResult<ValoracionDTOA> Editar(int idValoracion, ValoracionDTO dto)
        {
            var result = Put<ValoracionDTO, ActionResult<ValoracionDTOA>>(API_URIs.valoracionURI + "/Editar?idValoracion=" + idValoracion, dto);
            return result.data != null ? result.data : null;
        }

        public ActionResult Eliminar(int p_valoracion_oid)
        {
            var result = Delete<ActionResult>(API_URIs.valoracionURI + "/Eliminar/" + p_valoracion_oid);
            return result.data != null ? result.data : null;
        }

        public ActionResult<List<ValoracionDTOA>> Listar(int p_idusuario)
        {
            var result = Get<List<ValoracionDTOA>>(API_URIs.valoracionURI + "/Listaralumnosevento?p_idusuario=" + p_idusuario);
            return result.data != null ? result.data : null;
        }

        public ActionResult<List<ValoracionDTOA>> Listarentidad(int p_identidad)
        {
            var result = Get<List<ValoracionDTOA>>(API_URIs.valoracionURI + "/Listarentidad?p_identidad=" + p_identidad);
            return result.data != null ? result.data : null;
        }

        public ActionResult<List<ValoracionDTOA>> Listarinstalacion(int p_idinstalacion)
        {
            var result = Get<List<ValoracionDTOA>>(API_URIs.valoracionURI + "/Listarinstalacion?p_idinstalacion=" + p_idinstalacion);
            return result.data != null ? result.data : null;
        }

        public ActionResult<List<ValoracionDTOA>> Listarpista(int p_idpista)
        {
            var result = Get<List<ValoracionDTOA>>(API_URIs.valoracionURI + "/Listarpista?p_idpista=" + p_idpista);
            return result.data != null ? result.data : null;
        }

        public ActionResult<List<ValoracionDTOA>> Listartecnico(int p_idusuario)
        {
            var result = Get<List<ValoracionDTOA>>(API_URIs.valoracionURI + "/Listartecnico?p_idusuario=" + p_idusuario);
            return result.data != null ? result.data : null;
        }

        public ActionResult<ValoracionDTOA> Obtener(int idValoracion)
        {
            var result = Get<ValoracionDTOA>(API_URIs.valoracionURI + "/" + idValoracion);
            return result.data != null ? result.data : null;
        }

        public ActionResult<List<ValoracionDTOA>> ObtenerValoracionesRealizadas(int idUsuarioRegistrado)
        {
            var result = Get<List<ValoracionDTOA>>(API_URIs.valoracionURI + "/ObtenerValoracionesRealizadas?idUsuarioRegistrado=" + idUsuarioRegistrado);
            return result.data != null ? result.data : null;
        }

        public ActionResult Valorarentidad(int p_valoracion, int p_entidad)
        {
            var result = Post<string, ActionResult>(API_URIs.valoracionURI + "/Valorarentidad?p_valoracion=" + p_valoracion + "&p_entidad=" + p_entidad, "");
            return result.data != null ? result.data : null;
        }

        public ActionResult Valorarinstalacion(int p_valoracion, int p_instalacion)
        {
            var result = Post<string, ActionResult>(API_URIs.valoracionURI + "/Valorarinstalacion?p_valoracion=" + p_valoracion + "&p_instalacion=" + p_instalacion, "");
            return result.data != null ? result.data : null;
        }

        public ActionResult Valorarpista(int p_valoracion, int p_pista)
        {
            var result = Post<string, ActionResult>(API_URIs.valoracionURI + "/Valorarpista?p_valoracion=" + p_valoracion + "&p_pista=" + p_pista, "");
            return result.data != null ? result.data : null;
        }

        public ActionResult Valorartecnico(int p_valoracion, int p_tecnico)
        {
            var result = Post<string, ActionResult>(API_URIs.valoracionURI + "/Valorartecnico?p_valoracion=" + p_valoracion + "&p_tecnico=" + p_tecnico, "");
            return result.data != null ? result.data : null;
        }
    }
}
