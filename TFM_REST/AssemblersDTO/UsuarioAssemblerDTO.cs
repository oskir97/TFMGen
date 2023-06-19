using System;
using System.Collections.Generic;
using TFMGen.ApplicationCore.EN.TFM;
using TFM_REST.DTO;
using TFMGen.Infraestructure.Repository.TFM;

namespace TFM_REST.AssemblersDTO
{
public class UsuarioAssemblerDTO {
public static IList<UsuarioEN> ConvertList (IList<UsuarioDTO> lista)
{
        IList<UsuarioEN> result = new List<UsuarioEN>();
        foreach (UsuarioDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static UsuarioEN Convert (UsuarioDTO dto)
{
        UsuarioEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new UsuarioEN ();



                        newinstance.Idusuario = dto.Idusuario;
                        newinstance.Nombre = dto.Nombre;
                        newinstance.Email = dto.Email;
                        newinstance.Domicilio = dto.Domicilio;
                        newinstance.Telefono = dto.Telefono;
                        newinstance.Telefonoalternativo = dto.Telefonoalternativo;
                        newinstance.Fechanacimiento = dto.Fechanacimiento;
                        newinstance.Alta = dto.Alta;
                        newinstance.Baja = dto.Baja;
                        newinstance.Ubicacionactual = dto.Ubicacionactual;
                        newinstance.Apellidos = dto.Apellidos;
                        newinstance.Password = dto.Password;
                        if (dto.Reservas_oid != null) {
                                TFMGen.ApplicationCore.IRepository.TFM.IReservaRepository reservaCAD = new TFMGen.Infraestructure.Repository.TFM.ReservaRepository ();

                                newinstance.Reservas = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.ReservaEN>();
                                foreach (int entry in dto.Reservas_oid) {
                                        newinstance.Reservas.Add (reservaCAD.ReadOIDDefault (entry));
                                }
                        }

                        if (dto.Asitencias != null) {
                                TFMGen.ApplicationCore.IRepository.TFM.IAsitenciaRepository asitenciaCAD = new TFMGen.Infraestructure.Repository.TFM.AsitenciaRepository ();

                                newinstance.Asitencias = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.AsitenciaEN>();
                                foreach (AsitenciaDTO entry in dto.Asitencias) {
                                        newinstance.Asitencias.Add (AsitenciaAssemblerDTO.Convert (entry));
                                }
                        }
                        if (dto.NotificacionesRecibidas_oid != null) {
                                TFMGen.ApplicationCore.IRepository.TFM.INotificacionRepository notificacionCAD = new TFMGen.Infraestructure.Repository.TFM.NotificacionRepository ();

                                newinstance.NotificacionesRecibidas = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.NotificacionEN>();
                                foreach (int entry in dto.NotificacionesRecibidas_oid) {
                                        newinstance.NotificacionesRecibidas.Add (notificacionCAD.ReadOIDDefault (entry));
                                }
                        }
                        if (dto.Rol_oid != -1) {
                                TFMGen.ApplicationCore.IRepository.TFM.IRolRepository rolCAD = new TFMGen.Infraestructure.Repository.TFM.RolRepository ();

                                newinstance.Rol = rolCAD.ReadOIDDefault (dto.Rol_oid);
                        }
                        if (dto.NotificacionesEnviadas_oid != null) {
                                TFMGen.ApplicationCore.IRepository.TFM.INotificacionRepository notificacionCAD = new TFMGen.Infraestructure.Repository.TFM.NotificacionRepository ();

                                newinstance.NotificacionesEnviadas = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.NotificacionEN>();
                                foreach (int entry in dto.NotificacionesEnviadas_oid) {
                                        newinstance.NotificacionesEnviadas.Add (notificacionCAD.ReadOIDDefault (entry));
                                }
                        }
                        if (dto.ValoracionesUsuario_oid != null) {
                                TFMGen.ApplicationCore.IRepository.TFM.IValoracionRepository valoracionCAD = new TFMGen.Infraestructure.Repository.TFM.ValoracionRepository ();

                                newinstance.ValoracionesUsuario = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.ValoracionEN>();
                                foreach (int entry in dto.ValoracionesUsuario_oid) {
                                        newinstance.ValoracionesUsuario.Add (valoracionCAD.ReadOIDDefault (entry));
                                }
                        }
                        if (dto.ValoracionesAInstructores_oid != null) {
                                TFMGen.ApplicationCore.IRepository.TFM.IValoracionRepository valoracionCAD = new TFMGen.Infraestructure.Repository.TFM.ValoracionRepository ();

                                newinstance.ValoracionesAInstructores = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.ValoracionEN>();
                                foreach (int entry in dto.ValoracionesAInstructores_oid) {
                                        newinstance.ValoracionesAInstructores.Add (valoracionCAD.ReadOIDDefault (entry));
                                }
                        }
                        newinstance.Codigopostal = dto.Codigopostal;
                        newinstance.Localidad = dto.Localidad;
                        newinstance.Provincia = dto.Provincia;
                        if (dto.Eventos_oid != null) {
                                TFMGen.ApplicationCore.IRepository.TFM.IEventoRepository eventoCAD = new TFMGen.Infraestructure.Repository.TFM.EventoRepository ();

                                newinstance.Eventos = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.EventoEN>();
                                foreach (int entry in dto.Eventos_oid) {
                                        newinstance.Eventos.Add (eventoCAD.ReadOIDDefault (entry));
                                }
                        }
                        if (dto.EventosImpartidos_oid != null) {
                                TFMGen.ApplicationCore.IRepository.TFM.IEventoRepository eventoCAD = new TFMGen.Infraestructure.Repository.TFM.EventoRepository ();

                                newinstance.EventosImpartidos = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.EventoEN>();
                                foreach (int entry in dto.EventosImpartidos_oid) {
                                        newinstance.EventosImpartidos.Add (eventoCAD.ReadOIDDefault (entry));
                                }
                        }
                        if (dto.Incidencia_oid != null) {
                                TFMGen.ApplicationCore.IRepository.TFM.IIncidenciaRepository incidenciaCAD = new TFMGen.Infraestructure.Repository.TFM.IncidenciaRepository ();

                                newinstance.Incidencia = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.IncidenciaEN>();
                                foreach (int entry in dto.Incidencia_oid) {
                                        newinstance.Incidencia.Add (incidenciaCAD.ReadOIDDefault (entry));
                                }
                        }
                        if (dto.Entidad_oid != -1) {
                                TFMGen.ApplicationCore.IRepository.TFM.IEntidadRepository entidadCAD = new TFMGen.Infraestructure.Repository.TFM.EntidadRepository ();

                                newinstance.Entidad = entidadCAD.ReadOIDDefault (dto.Entidad_oid);
                        }
                        newinstance.Numero = dto.Numero;
                        if (dto.Instalacion_oid != null) {
                                TFMGen.ApplicationCore.IRepository.TFM.IInstalacionRepository instalacionCAD = new TFMGen.Infraestructure.Repository.TFM.InstalacionRepository ();

                                newinstance.Instalacion = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.InstalacionEN>();
                                foreach (int entry in dto.Instalacion_oid) {
                                        newinstance.Instalacion.Add (instalacionCAD.ReadOIDDefault (entry));
                                }
                        }
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
