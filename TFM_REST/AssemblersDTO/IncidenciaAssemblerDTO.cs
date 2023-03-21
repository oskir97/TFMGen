using System;
using System.Collections.Generic;
using TFMGen.ApplicationCore.EN.TFM;
using TFM_REST.DTO;
using TFMGen.Infraestructure.Repository.TFM;

namespace TFM_REST.AssemblersDTO
{
public class IncidenciaAssemblerDTO {
public static IList<IncidenciaEN> ConvertList (IList<IncidenciaDTO> lista)
{
        IList<IncidenciaEN> result = new List<IncidenciaEN>();
        foreach (IncidenciaDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static IncidenciaEN Convert (IncidenciaDTO dto)
{
        IncidenciaEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new IncidenciaEN ();



                        newinstance.Idincidencia = dto.Idincidencia;
                        if (dto.Usuario_oid != -1) {
                                TFMGen.ApplicationCore.IRepository.TFM.IUsuarioRepository usuarioCAD = new TFMGen.Infraestructure.Repository.TFM.UsuarioRepository ();

                                newinstance.Usuario = usuarioCAD.ReadOIDDefault (dto.Usuario_oid);
                        }
                        if (dto.Evento_oid != -1) {
                                TFMGen.ApplicationCore.IRepository.TFM.IEventoRepository eventoCAD = new TFMGen.Infraestructure.Repository.TFM.EventoRepository ();

                                newinstance.Evento = eventoCAD.ReadOIDDefault (dto.Evento_oid);
                        }
                        newinstance.Asunto = dto.Asunto;
                        newinstance.Descripcion = dto.Descripcion;
                        newinstance.Fechacancelada = dto.Fechacancelada;
                        newinstance.Fechareemplazada = dto.Fechareemplazada;
                }
        }
        catch (Exception)
        {
                throw;
        }
        return newinstance;
}
}
}
