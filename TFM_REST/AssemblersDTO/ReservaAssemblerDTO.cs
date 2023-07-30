using System;
using System.Collections.Generic;
using TFMGen.ApplicationCore.EN.TFM;
using TFM_REST.DTO;
using TFMGen.Infraestructure.Repository.TFM;

namespace TFM_REST.AssemblersDTO
{
public class ReservaAssemblerDTO {
public static IList<ReservaEN> ConvertList (IList<ReservaDTO> lista)
{
        IList<ReservaEN> result = new List<ReservaEN>();
        foreach (ReservaDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static ReservaEN Convert (ReservaDTO dto)
{
        ReservaEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new ReservaEN ();



                        newinstance.Idreserva = dto.Idreserva;
                        newinstance.Nombre = dto.Nombre;
                        newinstance.Apellidos = dto.Apellidos;
                        newinstance.Email = dto.Email;
                        newinstance.Telefono = dto.Telefono;
                        if (dto.Usuario_oid != -1) {
                                TFMGen.ApplicationCore.IRepository.TFM.IUsuarioRepository usuarioCAD = new TFMGen.Infraestructure.Repository.TFM.UsuarioRepository ();

                                newinstance.Usuario = usuarioCAD.ReadOIDDefault (dto.Usuario_oid);
                        }
                        newinstance.Cancelada = dto.Cancelada;
                        if (dto.Pista_oid != -1) {
                                TFMGen.ApplicationCore.IRepository.TFM.IPistaRepository pistaCAD = new TFMGen.Infraestructure.Repository.TFM.PistaRepository ();

                                newinstance.Pista = pistaCAD.ReadOIDDefault (dto.Pista_oid);
                        }
                        newinstance.Maxparticipantes = dto.Maxparticipantes;
                        if (dto.Pago_oid != -1) {
                                TFMGen.ApplicationCore.IRepository.TFM.IPagoRepository pagoCAD = new TFMGen.Infraestructure.Repository.TFM.PagoRepository ();

                                newinstance.Pago = pagoCAD.ReadOIDDefault (dto.Pago_oid);
                        }
                        if (dto.Horario_oid != -1) {
                                TFMGen.ApplicationCore.IRepository.TFM.IHorarioRepository horarioCAD = new TFMGen.Infraestructure.Repository.TFM.HorarioRepository ();

                                newinstance.Horario = horarioCAD.ReadOIDDefault (dto.Horario_oid);
                        }
                        newinstance.Fecha = dto.Fecha;

                        if (dto.Inscripciones != null) {
                                TFMGen.ApplicationCore.IRepository.TFM.IReservaRepository reservaCAD = new TFMGen.Infraestructure.Repository.TFM.ReservaRepository ();

                                newinstance.Inscripciones = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.ReservaEN>();
                                foreach (ReservaDTO entry in dto.Inscripciones) {
                                        newinstance.Inscripciones.Add (ReservaAssemblerDTO.Convert (entry));
                                }
                        }
                        if (dto.Partido_oid != -1) {
                                TFMGen.ApplicationCore.IRepository.TFM.IReservaRepository reservaCAD = new TFMGen.Infraestructure.Repository.TFM.ReservaRepository ();

                                newinstance.Partido = reservaCAD.ReadOIDDefault (dto.Partido_oid);
                        }
                        newinstance.Tipo = dto.Tipo;
                        if (dto.Notificacion_oid != null) {
                                TFMGen.ApplicationCore.IRepository.TFM.INotificacionRepository notificacionCAD = new TFMGen.Infraestructure.Repository.TFM.NotificacionRepository ();

                                newinstance.Notificacion = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.NotificacionEN>();
                                foreach (int entry in dto.Notificacion_oid) {
                                        newinstance.Notificacion.Add (notificacionCAD.ReadOIDDefault (entry));
                                }
                        }
                        newinstance.FechaCreacion = dto.FechaCreacion;
                        newinstance.FechaCancelada = dto.FechaCancelada;
                        if (dto.Deporte_oid != -1) {
                                TFMGen.ApplicationCore.IRepository.TFM.IDeporteRepository deporteCAD = new TFMGen.Infraestructure.Repository.TFM.DeporteRepository ();

                                newinstance.Deporte = deporteCAD.ReadOIDDefault (dto.Deporte_oid);
                        }
                        if (dto.Evento_oid != -1) {
                                TFMGen.ApplicationCore.IRepository.TFM.IEventoRepository eventoCAD = new TFMGen.Infraestructure.Repository.TFM.EventoRepository ();

                                newinstance.Evento = eventoCAD.ReadOIDDefault (dto.Evento_oid);
                        }
                        newinstance.Nivelpartido = dto.Nivelpartido;
                        newinstance.Descripcionpartido = dto.Descripcionpartido;
                        newinstance.Imagen = dto.Imagen;
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
