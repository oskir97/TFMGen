using System;
using System.Collections.Generic;
using TFMGen.ApplicationCore.EN.TFM;
using TFM_REST.DTO;
using TFMGen.Infraestructure.Repository.TFM;

namespace TFM_REST.AssemblersDTO
{
public class NotificacionAssemblerDTO {
public static IList<NotificacionEN> ConvertList (IList<NotificacionDTO> lista)
{
        IList<NotificacionEN> result = new List<NotificacionEN>();
        foreach (NotificacionDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static NotificacionEN Convert (NotificacionDTO dto)
{
        NotificacionEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new NotificacionEN ();



                        if (dto.Receptor_oid != -1) {
                                TFMGen.ApplicationCore.IRepository.TFM.IUsuarioRepository usuarioCAD = new TFMGen.Infraestructure.Repository.TFM.UsuarioRepository ();

                                newinstance.Receptor = usuarioCAD.ReadOIDDefault (dto.Receptor_oid);
                        }
                        newinstance.Idnotificacion = dto.Idnotificacion;
                        newinstance.Asunto = dto.Asunto;
                        newinstance.Descripcion = dto.Descripcion;
                        newinstance.Leida = dto.Leida;
                        if (dto.Emisor_oid != -1) {
                                TFMGen.ApplicationCore.IRepository.TFM.IUsuarioRepository usuarioCAD = new TFMGen.Infraestructure.Repository.TFM.UsuarioRepository ();

                                newinstance.Emisor = usuarioCAD.ReadOIDDefault (dto.Emisor_oid);
                        }
                        if (dto.Entidad_oid != -1) {
                                TFMGen.ApplicationCore.IRepository.TFM.IEntidadRepository entidadCAD = new TFMGen.Infraestructure.Repository.TFM.EntidadRepository ();

                                newinstance.Entidad = entidadCAD.ReadOIDDefault (dto.Entidad_oid);
                        }
                        newinstance.Tipo = dto.Tipo;
                        if (dto.Evento_oid != -1) {
                                TFMGen.ApplicationCore.IRepository.TFM.IEventoRepository eventoCAD = new TFMGen.Infraestructure.Repository.TFM.EventoRepository ();

                                newinstance.Evento = eventoCAD.ReadOIDDefault (dto.Evento_oid);
                        }
                        if (dto.Reserva_oid != -1) {
                                TFMGen.ApplicationCore.IRepository.TFM.IReservaRepository reservaCAD = new TFMGen.Infraestructure.Repository.TFM.ReservaRepository ();

                                newinstance.Reserva = reservaCAD.ReadOIDDefault (dto.Reserva_oid);
                        }
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
