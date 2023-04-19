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
    public class PistaRepository : BaseRepository, IPistaRepository
    {
        public ActionResult Asignarimagen(int p_oid, string p_imagen)
        {
            var result = Post<string, ActionResult>(API_URIs.pistaURI + "/Asignarimagen?p_oid=" + p_oid + "&p_imagen=" + p_imagen, "");
            return result.data != null ? result.data : null;
        }

        public ActionResult<List<PistaDTOA>> Buscar(string p_busqueda)
        {
            var result = Get<List<PistaDTOA>>(API_URIs.pistaURI + "/Buscar?p_busqueda=" + p_busqueda);
            return result.data != null ? result.data : null;
        }

        public ActionResult<PistaDTOA> Crear(PistaDTO dto)
        {
            var result = Post<PistaDTO, ActionResult<PistaDTOA>>(API_URIs.pistaURI + "/Crear", dto);
            return result.data != null ? result.data : null;
        }

        public ActionResult<PistaDTOA> Editar(int idPista, PistaDTO dto)
        {
            var result = Put<PistaDTO, ActionResult<PistaDTOA>>(API_URIs.pistaURI + "/Editar?idPista=" + idPista, dto);
            return result.data != null ? result.data : null;
        }

        public ActionResult Eliminar(int p_pista_oid)
        {
            var result = Delete<ActionResult>(API_URIs.pistaURI + "/Eliminar/" + p_pista_oid);
            return result.data != null ? result.data : null;
        }

        public ActionResult<bool> ExisteEvento(int p_oid, DateTime? p_fecha)
        {
            var result = Post<string, ActionResult<bool>>(API_URIs.pistaURI + "/ExisteEvento?p_oid=" + p_oid + "&p_fecha=" + p_fecha, "");
            return result.data != null ? result.data : null;
        }

        public ActionResult<bool> ExisteReserva(int p_oid, DateTime? p_fecha)
        {
            var result = Post<string, ActionResult<bool>>(API_URIs.pistaURI + "/ExisteReserva?p_oid=" + p_oid + "&p_fecha=" + p_fecha, "");
            return result.data != null ? result.data : null;
        }

        public ActionResult<List<PistaDTOA>> Listar()
        {
            var result = Get<List<PistaDTOA>>(API_URIs.pistaURI + "/Listar");
            return result.data != null ? result.data : null;
        }

        public ActionResult<List<PistaDTOA>> ListarEntidad(int p_identidad)
        {
            var result = Get<List<PistaDTOA>>(API_URIs.pistaURI + "/ListarEntidad?p_identidad=" + p_identidad);
            return result.data != null ? result.data : null;
        }

        public ActionResult<List<HorarioDTOA>> Listarhorariosdisponibles(int p_oid, DateTime? p_fecha)
        {
            var result = Get<List<HorarioDTOA>>(API_URIs.pistaURI + "/Listarhorariosdisponibles?p_oid=" + p_oid + "&p_fecha=" + p_fecha);
            return result.data != null ? result.data : null;
        }

        public ActionResult<PistaDTOA> Obtener(int idPista)
        {
            var result = Get<PistaDTOA>(API_URIs.pistaURI + "/" + idPista);
            return result.data != null ? result.data : null;
        }

        public ActionResult<List<PistaDTOA>> Obtenerpistasinstalacion(int p_idinstalacion)
        {
            var result = Get<List<PistaDTOA>>(API_URIs.pistaURI + "/Obtenerpistasinstalacion?p_idinstalacion=" + p_idinstalacion);
            return result.data != null ? result.data : null;
        }
    }
}
