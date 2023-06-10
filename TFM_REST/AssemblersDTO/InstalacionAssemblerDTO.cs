using System;
using System.Collections.Generic;
using TFMGen.ApplicationCore.EN.TFM;
using TFM_REST.DTO;
using TFMGen.Infraestructure.Repository.TFM;

namespace TFM_REST.AssemblersDTO
{
public class InstalacionAssemblerDTO {
public static IList<InstalacionEN> ConvertList (IList<InstalacionDTO> lista)
{
        IList<InstalacionEN> result = new List<InstalacionEN>();
        foreach (InstalacionDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static InstalacionEN Convert (InstalacionDTO dto)
{
        InstalacionEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new InstalacionEN ();



                        newinstance.Idinstalacion = dto.Idinstalacion;
                        newinstance.Nombre = dto.Nombre;
                        newinstance.Telefono = dto.Telefono;
                        newinstance.Domicilio = dto.Domicilio;
                        newinstance.Ubicacion = dto.Ubicacion;
                        newinstance.Imagen = dto.Imagen;
                        if (dto.Pistas_oid != null) {
                                TFMGen.ApplicationCore.IRepository.TFM.IPistaRepository pistaCAD = new TFMGen.Infraestructure.Repository.TFM.PistaRepository ();

                                newinstance.Pistas = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.PistaEN>();
                                foreach (int entry in dto.Pistas_oid) {
                                        newinstance.Pistas.Add (pistaCAD.ReadOIDDefault (entry));
                                }
                        }

                        if (dto.Materiales != null) {
                                TFMGen.ApplicationCore.IRepository.TFM.IMaterialRepository materialCAD = new TFMGen.Infraestructure.Repository.TFM.MaterialRepository ();

                                newinstance.Materiales = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.MaterialEN>();
                                foreach (MaterialDTO entry in dto.Materiales) {
                                        newinstance.Materiales.Add (MaterialAssemblerDTO.Convert (entry));
                                }
                        }
                        if (dto.Entidad_oid != -1) {
                                TFMGen.ApplicationCore.IRepository.TFM.IEntidadRepository entidadCAD = new TFMGen.Infraestructure.Repository.TFM.EntidadRepository ();

                                newinstance.Entidad = entidadCAD.ReadOIDDefault (dto.Entidad_oid);
                        }
                        if (dto.ValoracionesAInstalaciones_oid != null) {
                                TFMGen.ApplicationCore.IRepository.TFM.IValoracionRepository valoracionCAD = new TFMGen.Infraestructure.Repository.TFM.ValoracionRepository ();

                                newinstance.ValoracionesAInstalaciones = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.ValoracionEN>();
                                foreach (int entry in dto.ValoracionesAInstalaciones_oid) {
                                        newinstance.ValoracionesAInstalaciones.Add (valoracionCAD.ReadOIDDefault (entry));
                                }
                        }
                        newinstance.Codigopostal = dto.Codigopostal;
                        newinstance.Localidad = dto.Localidad;
                        newinstance.Provincia = dto.Provincia;
                        newinstance.Telefonoalternativo = dto.Telefonoalternativo;
                        newinstance.Visible = dto.Visible;
                        newinstance.Latitud = dto.Latitud;
                        newinstance.Longitud = dto.Longitud;
                        if (dto.Eventos_oid != null) {
                                TFMGen.ApplicationCore.IRepository.TFM.IEventoRepository eventoCAD = new TFMGen.Infraestructure.Repository.TFM.EventoRepository ();

                                newinstance.Eventos = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.EventoEN>();
                                foreach (int entry in dto.Eventos_oid) {
                                        newinstance.Eventos.Add (eventoCAD.ReadOIDDefault (entry));
                                }
                        }
                        if (dto.Usuario_oid != null) {
                                TFMGen.ApplicationCore.IRepository.TFM.IUsuarioRepository usuarioCAD = new TFMGen.Infraestructure.Repository.TFM.UsuarioRepository ();

                                newinstance.Usuario = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.UsuarioEN>();
                                foreach (int entry in dto.Usuario_oid) {
                                        newinstance.Usuario.Add (usuarioCAD.ReadOIDDefault (entry));
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
