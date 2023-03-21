using System;
using System.Collections.Generic;
using TFMGen.ApplicationCore.EN.TFM;
using TFM_REST.DTO;
using TFMGen.Infraestructure.Repository.TFM;

namespace TFM_REST.AssemblersDTO
{
public class IdiomaAssemblerDTO {
public static IList<IdiomaEN> ConvertList (IList<IdiomaDTO> lista)
{
        IList<IdiomaEN> result = new List<IdiomaEN>();
        foreach (IdiomaDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static IdiomaEN Convert (IdiomaDTO dto)
{
        IdiomaEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new IdiomaEN ();



                        newinstance.Ididioma = dto.Ididioma;
                        newinstance.Nombre = dto.Nombre;
                        newinstance.Cultura = dto.Cultura;
                        if (dto.EstadoPista_l10n_oid != null) {
                                TFMGen.ApplicationCore.IRepository.TFM.IPistaEstado_l10nRepository pistaEstado_l10nCAD = new TFMGen.Infraestructure.Repository.TFM.PistaEstado_l10nRepository ();

                                newinstance.EstadoPista_l10n = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.PistaEstado_l10nEN>();
                                foreach (int entry in dto.EstadoPista_l10n_oid) {
                                        newinstance.EstadoPista_l10n.Add (pistaEstado_l10nCAD.ReadOIDDefault (entry));
                                }
                        }
                        if (dto.Deporte_l10n_oid != null) {
                                TFMGen.ApplicationCore.IRepository.TFM.IDeporte_l10nRepository deporte_l10nCAD = new TFMGen.Infraestructure.Repository.TFM.Deporte_l10nRepository ();

                                newinstance.Deporte_l10n = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.Deporte_l10nEN>();
                                foreach (int entry in dto.Deporte_l10n_oid) {
                                        newinstance.Deporte_l10n.Add (deporte_l10nCAD.ReadOIDDefault (entry));
                                }
                        }
                        if (dto.PagoTipo_l10n_oid != null) {
                                TFMGen.ApplicationCore.IRepository.TFM.IPagoTipo_l10nRepository pagoTipo_l10nCAD = new TFMGen.Infraestructure.Repository.TFM.PagoTipo_l10nRepository ();

                                newinstance.PagoTipo_l10n = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.PagoTipo_l10nEN>();
                                foreach (int entry in dto.PagoTipo_l10n_oid) {
                                        newinstance.PagoTipo_l10n.Add (pagoTipo_l10nCAD.ReadOIDDefault (entry));
                                }
                        }
                        if (dto.Rol_l10n_oid != null) {
                                TFMGen.ApplicationCore.IRepository.TFM.IRol_l10nRepository rol_l10nCAD = new TFMGen.Infraestructure.Repository.TFM.Rol_l10nRepository ();

                                newinstance.Rol_l10n = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.Rol_l10nEN>();
                                foreach (int entry in dto.Rol_l10n_oid) {
                                        newinstance.Rol_l10n.Add (rol_l10nCAD.ReadOIDDefault (entry));
                                }
                        }
                        if (dto.DiaSemana_l10n_oid != null) {
                                TFMGen.ApplicationCore.IRepository.TFM.IDiaSemana_l10nRepository diaSemana_l10nCAD = new TFMGen.Infraestructure.Repository.TFM.DiaSemana_l10nRepository ();

                                newinstance.DiaSemana_l10n = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.DiaSemana_l10nEN>();
                                foreach (int entry in dto.DiaSemana_l10n_oid) {
                                        newinstance.DiaSemana_l10n.Add (diaSemana_l10nCAD.ReadOIDDefault (entry));
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
