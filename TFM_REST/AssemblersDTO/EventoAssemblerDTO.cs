using System;
using System.Collections.Generic;
using TFMGen.ApplicationCore.EN.TFM;
using TFM_REST.DTO;
using TFMGen.Infraestructure.Repository.TFM;

namespace TFM_REST.AssemblersDTO
{
public class EventoAssemblerDTO {
public static IList<EventoEN> ConvertList (IList<EventoDTO> lista)
{
        IList<EventoEN> result = new List<EventoEN>();
        foreach (EventoDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static EventoEN Convert (EventoDTO dto)
{
        EventoEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new EventoEN ();



                        newinstance.Idevento = dto.Idevento;
                        newinstance.Nombre = dto.Nombre;
                        newinstance.Descripcion = dto.Descripcion;
                        if (dto.Notificaciones_oid != null) {
                                TFMGen.ApplicationCore.IRepository.TFM.INotificacionRepository notificacionCAD = new TFMGen.Infraestructure.Repository.TFM.NotificacionRepository ();

                                newinstance.Notificaciones = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.NotificacionEN>();
                                foreach (int entry in dto.Notificaciones_oid) {
                                        newinstance.Notificaciones.Add (notificacionCAD.ReadOIDDefault (entry));
                                }
                        }
                        if (dto.Entidad_oid != -1) {
                                TFMGen.ApplicationCore.IRepository.TFM.IEntidadRepository entidadCAD = new TFMGen.Infraestructure.Repository.TFM.EntidadRepository ();

                                newinstance.Entidad = entidadCAD.ReadOIDDefault (dto.Entidad_oid);
                        }
                        if (dto.Asitencias_oid != null) {
                                TFMGen.ApplicationCore.IRepository.TFM.IAsitenciaRepository asitenciaCAD = new TFMGen.Infraestructure.Repository.TFM.AsitenciaRepository ();

                                newinstance.Asitencias = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.AsitenciaEN>();
                                foreach (int entry in dto.Asitencias_oid) {
                                        newinstance.Asitencias.Add (asitenciaCAD.ReadOIDDefault (entry));
                                }
                        }
                        if (dto.Usuarios_oid != null) {
                                TFMGen.ApplicationCore.IRepository.TFM.IUsuarioRepository usuarioCAD = new TFMGen.Infraestructure.Repository.TFM.UsuarioRepository ();

                                newinstance.Usuarios = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.UsuarioEN>();
                                foreach (int entry in dto.Usuarios_oid) {
                                        newinstance.Usuarios.Add (usuarioCAD.ReadOIDDefault (entry));
                                }
                        }
                        if (dto.Tecnicos_oid != null) {
                                TFMGen.ApplicationCore.IRepository.TFM.IUsuarioRepository usuarioCAD = new TFMGen.Infraestructure.Repository.TFM.UsuarioRepository ();

                                newinstance.Tecnicos = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.UsuarioEN>();
                                foreach (int entry in dto.Tecnicos_oid) {
                                        newinstance.Tecnicos.Add (usuarioCAD.ReadOIDDefault (entry));
                                }
                        }
                        if (dto.Horarios_oid != null) {
                                TFMGen.ApplicationCore.IRepository.TFM.IHorarioRepository horarioCAD = new TFMGen.Infraestructure.Repository.TFM.HorarioRepository ();

                                newinstance.Horarios = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.HorarioEN>();
                                foreach (int entry in dto.Horarios_oid) {
                                        newinstance.Horarios.Add (horarioCAD.ReadOIDDefault (entry));
                                }
                        }
                        if (dto.Incidencia_oid != null) {
                                TFMGen.ApplicationCore.IRepository.TFM.IIncidenciaRepository incidenciaCAD = new TFMGen.Infraestructure.Repository.TFM.IncidenciaRepository ();

                                newinstance.Incidencia = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.IncidenciaEN>();
                                foreach (int entry in dto.Incidencia_oid) {
                                        newinstance.Incidencia.Add (incidenciaCAD.ReadOIDDefault (entry));
                                }
                        }
                        if (dto.DiasSemana_oid != null) {
                                TFMGen.ApplicationCore.IRepository.TFM.IDiaSemanaRepository diaSemanaCAD = new TFMGen.Infraestructure.Repository.TFM.DiaSemanaRepository ();

                                newinstance.DiasSemana = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.DiaSemanaEN>();
                                foreach (int entry in dto.DiasSemana_oid) {
                                        newinstance.DiasSemana.Add (diaSemanaCAD.ReadOIDDefault (entry));
                                }
                        }
                        newinstance.Activo = dto.Activo;
                        newinstance.Plazas = dto.Plazas;
                        if (dto.Deporte_oid != -1) {
                                TFMGen.ApplicationCore.IRepository.TFM.IDeporteRepository deporteCAD = new TFMGen.Infraestructure.Repository.TFM.DeporteRepository ();

                                newinstance.Deporte = deporteCAD.ReadOIDDefault (dto.Deporte_oid);
                        }
                        newinstance.Inicio = dto.Inicio;
                        newinstance.Fin = dto.Fin;
                        if (dto.Reservas_oid != null) {
                                TFMGen.ApplicationCore.IRepository.TFM.IReservaRepository reservaCAD = new TFMGen.Infraestructure.Repository.TFM.ReservaRepository ();

                                newinstance.Reservas = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.ReservaEN>();
                                foreach (int entry in dto.Reservas_oid) {
                                        newinstance.Reservas.Add (reservaCAD.ReadOIDDefault (entry));
                                }
                        }
                        if (dto.Instalacion_oid != -1) {
                                TFMGen.ApplicationCore.IRepository.TFM.IInstalacionRepository instalacionCAD = new TFMGen.Infraestructure.Repository.TFM.InstalacionRepository ();

                                newinstance.Instalacion = instalacionCAD.ReadOIDDefault (dto.Instalacion_oid);
                        }
                        newinstance.Precio = dto.Precio;
                        if (dto.Valoraciones_oid != null) {
                                TFMGen.ApplicationCore.IRepository.TFM.IValoracionRepository valoracionCAD = new TFMGen.Infraestructure.Repository.TFM.ValoracionRepository ();

                                newinstance.Valoraciones = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.ValoracionEN>();
                                foreach (int entry in dto.Valoraciones_oid) {
                                        newinstance.Valoraciones.Add (valoracionCAD.ReadOIDDefault (entry));
                                }
                        }
                        newinstance.Imagen = dto.Imagen;
                        if (dto.Pista_oid != -1) {
                                TFMGen.ApplicationCore.IRepository.TFM.IPistaRepository pistaCAD = new TFMGen.Infraestructure.Repository.TFM.PistaRepository ();

                                newinstance.Pista = pistaCAD.ReadOIDDefault (dto.Pista_oid);
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
