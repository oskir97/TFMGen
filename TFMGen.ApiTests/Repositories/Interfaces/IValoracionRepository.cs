using Microsoft.AspNetCore.Mvc;
using TFMGen.ApiTests.Models;
using TFMGen.ApiTests.Models.DTO;
using TFMGen.ApiTests.Models.DTOA;

namespace TFMGen.ApiTests.Repositories.Interfaces
{
    public interface IValoracionRepository
    {
        public ResponseModel<ValoracionDTOA> Crear(ValoracionDTO dto);

        public ResponseModel<ValoracionDTOA> Editar(int idValoracion, ValoracionDTO dto);

        public ResponseModel<ActionResult> Eliminar(int p_valoracion_oid);

        public ResponseModel<List<ValoracionDTOA>> Listar(int p_idusuario);

        public ResponseModel<List<ValoracionDTOA>> Listarentidad(int p_identidad);

        public ResponseModel<List<ValoracionDTOA>> Listarinstalacion(int p_idinstalacion);

        public ResponseModel<List<ValoracionDTOA>> Listarpista(int p_idpista);

        public ResponseModel<List<ValoracionDTOA>> Listartecnico(int p_idusuario);

        public ResponseModel<ValoracionDTOA> Obtener(int idValoracion);

        public ResponseModel<List<ValoracionDTOA>> ObtenerValoracionesRealizadas(int idUsuarioRegistrado);

        public ResponseModel<ActionResult> Valorarentidad(int p_valoracion, int p_entidad);

        public ResponseModel<ActionResult> Valorarinstalacion(int p_valoracion, int p_instalacion);

        public ResponseModel<ActionResult> Valorarpista(int p_valoracion, int p_pista);

        public ResponseModel<ActionResult> Valorartecnico(int p_valoracion, int p_tecnico);

        public ResponseModel<List<ValoracionDTOA>> Listartodas();
    }
}
