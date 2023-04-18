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
    public interface IPistaRepository
    {
        public ActionResult<PistaDTOA> Obtener(int idPista);
        public ActionResult<System.Collections.Generic.List<PistaDTOA>> ListarEntidad(int p_identidad);
        public ActionResult<System.Collections.Generic.List<PistaDTOA>> Buscar(string p_busqueda);
        public ActionResult<System.Collections.Generic.List<PistaDTOA>> Listar();
        public ActionResult<System.Collections.Generic.List<PistaDTOA>> Obtenerpistasinstalacion(int p_idinstalacion);
        public ActionResult<PistaDTOA> Crear(PistaDTO dto);
        public ActionResult<PistaDTOA> Editar(int idPista, PistaDTO dto);
        public ActionResult Eliminar(int p_pista_oid);
        public ActionResult<bool> ExisteReserva(int p_oid, Nullable<DateTime> p_fecha);
        public ActionResult<bool> ExisteEvento(int p_oid, Nullable<DateTime> p_fecha);
        public ActionResult<System.Collections.Generic.List<HorarioDTOA>> Listarhorariosdisponibles(int p_oid, Nullable<DateTime> p_fecha);
        public ActionResult Asignarimagen(int p_oid, string p_imagen);

    }
}
