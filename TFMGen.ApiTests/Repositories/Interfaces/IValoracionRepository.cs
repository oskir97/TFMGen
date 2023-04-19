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
    public interface IValoracionRepository
    {
        public ActionResult<List<ValoracionDTOA>> ObtenerValoracionesRealizadas(int idUsuarioRegistrado);
        public ActionResult<ValoracionDTOA> Obtener(int idValoracion);
        public ActionResult<System.Collections.Generic.List<ValoracionDTOA>> Listar(int p_idusuario);
        public ActionResult<System.Collections.Generic.List<ValoracionDTOA>> Listartecnico(int p_idusuario);
        public ActionResult<System.Collections.Generic.List<ValoracionDTOA>> Listarentidad(int p_identidad);
        public ActionResult<System.Collections.Generic.List<ValoracionDTOA>> Listarpista(int p_idpista);
        public ActionResult<System.Collections.Generic.List<ValoracionDTOA>> Listarinstalacion(int p_idinstalacion);
        public ActionResult<ValoracionDTOA> Crear( ValoracionDTO dto);
        public ActionResult<ValoracionDTOA> Editar(int idValoracion, ValoracionDTO dto);
        public ActionResult Eliminar(int p_valoracion_oid);
        public ActionResult Valorarpista(int p_valoracion, int p_pista);
        public ActionResult Valorarentidad(int p_valoracion, int p_entidad);
        public ActionResult Valorarinstalacion(int p_valoracion, int p_instalacion);
        public ActionResult Valorartecnico(int p_valoracion, int p_tecnico);

    }
}
