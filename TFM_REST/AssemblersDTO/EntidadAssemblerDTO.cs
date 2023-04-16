using System;
using System.Collections.Generic;
using TFMGen.ApplicationCore.EN.TFM;
using TFM_REST.DTO;
using TFMGen.Infraestructure.Repository.TFM;

namespace TFM_REST.AssemblersDTO
{
public class EntidadAssemblerDTO {
public static IList<EntidadEN> ConvertList (IList<EntidadDTO> lista)
{
        IList<EntidadEN> result = new List<EntidadEN>();
        foreach (EntidadDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static EntidadEN Convert (EntidadDTO dto)
{
        EntidadEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new EntidadEN ();



                        newinstance.Identidad = dto.Identidad;
                        newinstance.Nombre = dto.Nombre;
                        newinstance.Email = dto.Email;
                        newinstance.Telefono = dto.Telefono;
                        newinstance.Domicilio = dto.Domicilio;
                        newinstance.Alta = dto.Alta;
                        newinstance.Baja = dto.Baja;
                        newinstance.Cifnif = dto.Cifnif;
                        newinstance.Telefonoalternativo = dto.Telefonoalternativo;

                        if (dto.Pistas != null) {
                                TFMGen.ApplicationCore.IRepository.TFM.IPistaRepository pistaCAD = new TFMGen.Infraestructure.Repository.TFM.PistaRepository ();

                                newinstance.Pistas = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.PistaEN>();
                                foreach (PistaDTO entry in dto.Pistas) {
                                        newinstance.Pistas.Add (PistaAssemblerDTO.Convert (entry));
                                }
                        }
                        if (dto.Notificaciones_oid != null) {
                                TFMGen.ApplicationCore.IRepository.TFM.INotificacionRepository notificacionCAD = new TFMGen.Infraestructure.Repository.TFM.NotificacionRepository ();

                                newinstance.Notificaciones = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.NotificacionEN>();
                                foreach (int entry in dto.Notificaciones_oid) {
                                        newinstance.Notificaciones.Add (notificacionCAD.ReadOIDDefault (entry));
                                }
                        }

                        if (dto.Instalaciones != null) {
                                TFMGen.ApplicationCore.IRepository.TFM.IInstalacionRepository instalacionCAD = new TFMGen.Infraestructure.Repository.TFM.InstalacionRepository ();

                                newinstance.Instalaciones = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.InstalacionEN>();
                                foreach (InstalacionDTO entry in dto.Instalaciones) {
                                        newinstance.Instalaciones.Add (InstalacionAssemblerDTO.Convert (entry));
                                }
                        }
                        if (dto.ValoracionesAEntidades_oid != null) {
                                TFMGen.ApplicationCore.IRepository.TFM.IValoracionRepository valoracionCAD = new TFMGen.Infraestructure.Repository.TFM.ValoracionRepository ();

                                newinstance.ValoracionesAEntidades = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.ValoracionEN>();
                                foreach (int entry in dto.ValoracionesAEntidades_oid) {
                                        newinstance.ValoracionesAEntidades.Add (valoracionCAD.ReadOIDDefault (entry));
                                }
                        }
                        newinstance.Codigopostal = dto.Codigopostal;
                        newinstance.Localidad = dto.Localidad;
                        newinstance.Provincia = dto.Provincia;
                        newinstance.Imagen = dto.Imagen;
                        newinstance.Configuracion = dto.Configuracion;

                        if (dto.Eventos != null) {
                                TFMGen.ApplicationCore.IRepository.TFM.IEventoRepository eventoCAD = new TFMGen.Infraestructure.Repository.TFM.EventoRepository ();

                                newinstance.Eventos = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.EventoEN>();
                                foreach (EventoDTO entry in dto.Eventos) {
                                        newinstance.Eventos.Add (EventoAssemblerDTO.Convert (entry));
                                }
                        }
                        if (dto.Usuarios_oid != null) {
                                TFMGen.ApplicationCore.IRepository.TFM.IUsuarioRepository usuarioCAD = new TFMGen.Infraestructure.Repository.TFM.UsuarioRepository ();

                                newinstance.Usuarios = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.UsuarioEN>();
                                foreach (int entry in dto.Usuarios_oid) {
                                        newinstance.Usuarios.Add (usuarioCAD.ReadOIDDefault (entry));
                                }
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
