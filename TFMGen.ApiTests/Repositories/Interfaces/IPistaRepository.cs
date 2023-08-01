using Microsoft.AspNetCore.Mvc;
using TFMGen.ApiTests.Models;
using TFMGen.ApiTests.Models.DTO;
using TFMGen.ApiTests.Models.DTOA;

namespace TFMGen.ApiTests.Repositories.Interfaces
{
    public interface IPistaRepository
    {
        public ResponseModel<ActionResult> Asignarimagen(int p_oid, string p_imagen);

        public ResponseModel<List<PistaDTOA>> Buscar(string p_busqueda);

        public ResponseModel<PistaDTOA> Crear(PistaDTO dto);

        public ResponseModel<PistaDTOA> Editar(int idPista, PistaDTO dto);

        public ResponseModel<ActionResult> Eliminar(int p_pista_oid);

        public ResponseModel<ActionResult<bool>> ExisteEvento(int p_oid, DateTime? p_fecha);

        public ResponseModel<ActionResult<bool>> ExisteReserva(int p_oid, DateTime? p_fecha);

        public ResponseModel<List<PistaDTOA>> Listar();

        public ResponseModel<List<PistaDTOA>> ListarEntidad(int p_identidad);

        public ResponseModel<List<HorarioDTOA>> Listarhorariosdisponibles(int p_oid, DateTime? p_fecha);

        public ResponseModel<PistaDTOA> Obtener(int idPista);

        public ResponseModel<List<PistaDTOA>> Obtenerpistasinstalacion(int p_idinstalacion);

        public ResponseModel<List<PistaDTOA>> Listartodas();

        public ResponseModel<List<PistaDTOA>> ObtenerPistaHorario(int idHorario);

    }
}
