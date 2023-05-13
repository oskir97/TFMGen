using System;
using System.Collections.Generic;
using TFMGen.ApplicationCore.EN.TFM;
using TFM_REST.DTO;
using TFMGen.Infraestructure.Repository.TFM;

namespace TFM_REST.AssemblersDTO
{
public class PistaAssemblerDTO {
public static IList<PistaEN> ConvertList (IList<PistaDTO> lista)
{
        IList<PistaEN> result = new List<PistaEN>();
        foreach (PistaDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static PistaEN Convert (PistaDTO dto)
{
        PistaEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new PistaEN ();



                        newinstance.Idpista = dto.Idpista;
                        newinstance.Nombre = dto.Nombre;
                        newinstance.Ubicacion = dto.Ubicacion;
                        newinstance.Imagen = dto.Imagen;
                        newinstance.Maxreservas = dto.Maxreservas;
                        if (dto.ReservasCreadas_oid != null) {
                                TFMGen.ApplicationCore.IRepository.TFM.IReservaRepository reservaCAD = new TFMGen.Infraestructure.Repository.TFM.ReservaRepository ();

                                newinstance.ReservasCreadas = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.ReservaEN>();
                                foreach (int entry in dto.ReservasCreadas_oid) {
                                        newinstance.ReservasCreadas.Add (reservaCAD.ReadOIDDefault (entry));
                                }
                        }
                        if (dto.Entidad_oid != -1) {
                                TFMGen.ApplicationCore.IRepository.TFM.IEntidadRepository entidadCAD = new TFMGen.Infraestructure.Repository.TFM.EntidadRepository ();

                                newinstance.Entidad = entidadCAD.ReadOIDDefault (dto.Entidad_oid);
                        }
                        if (dto.Instalacion_oid != -1) {
                                TFMGen.ApplicationCore.IRepository.TFM.IInstalacionRepository instalacionCAD = new TFMGen.Infraestructure.Repository.TFM.InstalacionRepository ();

                                newinstance.Instalacion = instalacionCAD.ReadOIDDefault (dto.Instalacion_oid);
                        }
                        if (dto.EstadosPista_oid != -1) {
                                TFMGen.ApplicationCore.IRepository.TFM.IPistaEstadoRepository pistaEstadoCAD = new TFMGen.Infraestructure.Repository.TFM.PistaEstadoRepository ();

                                newinstance.EstadosPista = pistaEstadoCAD.ReadOIDDefault (dto.EstadosPista_oid);
                        }
                        if (dto.ValoracionesAPistas_oid != null) {
                                TFMGen.ApplicationCore.IRepository.TFM.IValoracionRepository valoracionCAD = new TFMGen.Infraestructure.Repository.TFM.ValoracionRepository ();

                                newinstance.ValoracionesAPistas = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.ValoracionEN>();
                                foreach (int entry in dto.ValoracionesAPistas_oid) {
                                        newinstance.ValoracionesAPistas.Add (valoracionCAD.ReadOIDDefault (entry));
                                }
                        }

                        if (dto.Horarios != null) {
                                TFMGen.ApplicationCore.IRepository.TFM.IHorarioRepository horarioCAD = new TFMGen.Infraestructure.Repository.TFM.HorarioRepository ();

                                newinstance.Horarios = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.HorarioEN>();
                                foreach (HorarioDTO entry in dto.Horarios) {
                                        newinstance.Horarios.Add (HorarioAssemblerDTO.Convert (entry));
                                }
                        }
                        if (dto.Deporte_oid != null) {
                                TFMGen.ApplicationCore.IRepository.TFM.IDeporteRepository deporteCAD = new TFMGen.Infraestructure.Repository.TFM.DeporteRepository ();

                                newinstance.Deporte = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.DeporteEN>();
                                foreach (int entry in dto.Deporte_oid) {
                                        newinstance.Deporte.Add (deporteCAD.ReadOIDDefault (entry));
                                }
                        }
                        newinstance.Visible = dto.Visible;
                        newinstance.Precio = dto.Precio;
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
